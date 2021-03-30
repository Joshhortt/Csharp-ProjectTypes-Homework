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

        public IndexModel(ApplicationDbContext db)  // 13.  add ApplicationDbContext to using BookRazorList.Model;
        {
            _db = db;  // 14.
		}

		public IEnumerable<TheBook> TheBooks { get; set; }   // 15. 

		public async Task OnGet()  // 17.  change void to async Task in the Get handler
        {
            TheBooks = await _db.TheBook.ToListAsync();  // 16. add await _db.TheBook.ToListAsync() --  using Microsoft.EntityFrameworkCore;
        }
    }
}
