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

        public IActionResult Upsert(int? id)  // 31. Copy paste Action method Index and rename Upsert, include parameters.
        {
            Book = new TheBook();  // 32. new book instance
            if (id == null)    // 33. Initialize condition create 
            {
                // 34. if null create
                return View(Book);
            }
            //35.if not than update (we need to retrieve the book from the db)
            Book = _db.Books.FirstOrDefault(u => u.Id == id);

            if (Book == null)  // 36. Initialize condition update
            {
                // 37. if it is null than there's no book in the db
                return NotFound();
            }
            // 38. otherwise we return that book to the view regardless it was used for create or update.
            return View(Book);
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
