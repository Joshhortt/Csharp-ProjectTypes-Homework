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
        [BindProperty]
        public TheBook Book { get; set; }  // 20. Add property
        public BooksController(ApplicationDbContext db)  // 21. Add Constructor
        {
            _db = db;  // 22. 
        }

        public IActionResult Index()  // 16. Right-click over Index and add a razor view called Index.
		{
			return View();
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
