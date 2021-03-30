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
    }
}
