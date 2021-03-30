using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookRazorList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookRazorList.Pages.TheBookList
{
    public class CreateModel : PageModel
    {
        // include dependency injection
        private readonly ApplicationDbContext _db;  // 22.  add ApplicationDbContext to using BookRazorList.Model;

        public CreateModel(ApplicationDbContext db)  // 23. Constructor --> add ApplicationDbContext to using BookRazorList.Model;
        {
            _db = db;  // 24.
        }

		public TheBook TheBook { get; set; }  // 25. Add prop

		public void OnGet()
        {
        }
    }
}
