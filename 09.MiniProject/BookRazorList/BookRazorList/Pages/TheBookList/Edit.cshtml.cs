using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookRazorList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookRazorList.Pages.TheBookList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;  // 41.

        public EditModel(ApplicationDbContext db) // 42.
        {
            _db = db;  // 43.
        }

        [BindProperty]  // 47. 
        public TheBook TheBook { get; set; }  // 44 .

        public async Task OnGet(int id)  // 45.
        {
            TheBook = await _db.TheBook.FindAsync(id);  // 46.
        }

        // Implement the Edit Post Handler
        public async Task<IActionResult> OnPost()  // 51.
        {
            if (ModelState.IsValid)    // 52. 
            {
                var BookFromDb = await _db.TheBook.FindAsync(TheBook.Id);  // 53. updating the db
                BookFromDb.Name = TheBook.Name;  // 54.
                BookFromDb.ISBN = TheBook.ISBN;  // 55.
                BookFromDb.Author = TheBook.Author;  // 56.

                await _db.SaveChangesAsync();  // 57. update the book object inside the db

                return RedirectToPage("Index");  // 58.
            }
            return RedirectToPage();  // 59.
        }
    }
}


