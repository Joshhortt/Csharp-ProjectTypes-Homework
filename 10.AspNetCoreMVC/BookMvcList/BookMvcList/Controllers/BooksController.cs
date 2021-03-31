using BookMvcList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 15. Create a new Controller + F5 to test it. Next we need to add a View - right-click Index and add view.
namespace BookMvcList.Controllers
{
	public class BooksController : Controller
	{
        private readonly ApplicationDbContext _db;  // 19. 
        [BindProperty]  // 30. Add Bindproperty
        public TheBook Book { get; set; }  // 20. Add property
        public BooksController(ApplicationDbContext db)  // 21. Add Constructor
        {
            _db = db;  // 22. 
        }

        public IActionResult Index()  // 16. Right-click over Index and add a razor view called Index.
		{
			return View();
		}

        public IActionResult Upsert(int? id)  // 31. Copy/paste Action method Index and rename Upsert, include parameters.
        {
            Book = new TheBook();  // 32. Create new book instance.
            if (id == null)    // 33. Initialize condition create.
            {
                // 34. If null create.
                return View(Book);
            }
            //35. If not than update (we need to retrieve the book from the db).
            Book = _db.Books.FirstOrDefault(u => u.Id == id);

            if (Book == null)  // 36. Initialize condition update.
            {
                // 37. If it is null than there's no book in the db.
                return NotFound();
            }
            // 38. Otherwise we return that book to the view, regardless it was used for create or update.
            return View(Book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()  // 52. Add the Upsert POST action method.
        {
            if (ModelState.IsValid)  // 53. If Model state is valid or not.
            {
                if (Book.Id == 0)  // 54. If id is equal to zero.
                {
                    //55. If so than it's a create, so we Add Book.
                    _db.Books.Add(Book);
                }
                else  // 56. else it's an update.
                {
                    //57. Otherwise it's aN update, so we update Book.
                    _db.Books.Update(Book);
                }
                _db.SaveChanges();  // 58. Once all is done, we need to push/save the changes.
                return RedirectToAction("Index");  // 59. Redirects to the Index Action.
            }
            return View(Book);  // 60. Redirects to Index Action and loads all the books again.
        }

        #region API Calls  
        // 18. Copy paste Api Calls form the Razor Application in here
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Books.ToListAsync() });  // 23. ctrl + . MicrosoftEntityFrameworkCore
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookFromDb = await _db.Books.FirstOrDefaultAsync(u => u.Id == id);
            if (bookFromDb == null)
            {
                return Json(new { success = false, message = "Error when Deleting" });
            }
            _db.Books.Remove(bookFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete was successful" });
        }
        #endregion
    }
}
