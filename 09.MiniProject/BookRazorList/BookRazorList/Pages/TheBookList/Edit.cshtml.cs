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

        [BindProperty]
        public TheBook TheBook { get; set; }

        public async Task OnGet(int id)
        {
            TheBook = await _db.TheBook.FindAsync(id);
        }
    }
}
