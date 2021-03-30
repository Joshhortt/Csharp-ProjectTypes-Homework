using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookRazorList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookRazorList.Pages.TheBookList
{
    public class IndexModel : PageModel
    {
        // include dependency injection
        private readonly ApplicationDbContext _db;  // 12.  add ApplicationDbContext to using BookRazorList.Model;

        public IndexModel(ApplicationDbContext db)  // 13. Constructor -->  add ApplicationDbContext to using BookRazorList.Model;
        {
            _db = db;  // 14.
        }

        public IEnumerable<TheBook> TheBooks { get; set; }   // 15. 

        public async Task OnGet()  // 17.  change void to async Task in the Get handler
        {
            TheBooks = await _db.TheBook.ToListAsync();  // 16. add await _db.TheBook.ToListAsync() --  using Microsoft.EntityFrameworkCore;
        }

        // Implement OnPostDelete handler
        public async Task<IActionResult> OnPostDelete(int id)  // 61. 
        {
            var theBook = await _db.TheBook.FindAsync(id);  // 62.
            if (theBook == null)  // 63.
            {
                return NotFound();  // 64.
            }
            _db.TheBook.Remove(theBook);  // 65.
            await _db.SaveChangesAsync();  // 66.

            return RedirectToPage("Index");  // 67.
        }
    }
}
