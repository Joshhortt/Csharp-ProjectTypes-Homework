using BookRazorList.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRazorList.Controllers
{
    [Route("api/[Controller]")] // 72. add route
    [ApiController]          // 73. Api
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;  // 74.

        public BookController(ApplicationDbContext db)   // 75. Constructor
        {
            _db = db;  // 76.
        }

        [HttpGet]   // 77. Http get
        public async Task<IActionResult> GetAll()  // 78.
        {
            return Json(new { data = await _db.TheBook.ToListAsync() }); // 79.
        }


        [HttpDelete]  // 83.
        public async Task<IActionResult> Delete(int id)  // 84.
        {
            var bookFromDb = await _db.TheBook.FirstOrDefaultAsync(u => u.Id == id);  // 85.
            if (bookFromDb == null)  // 86.
            {
                return Json(new { success = false, message = "Error while Deleting" });  // 87.
            }

            _db.TheBook.Remove(bookFromDb);  // 88.
            await _db.SaveChangesAsync();   // 89.
            return Json(new { success = true, message = "Delete successful" });  // 89.
        }
    }
}
