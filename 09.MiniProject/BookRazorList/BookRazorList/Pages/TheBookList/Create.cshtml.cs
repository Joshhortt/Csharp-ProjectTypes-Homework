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

        [BindProperty]    // 38. binds the property of OnPost() without needding to passing in the values 
        public TheBook TheBook { get; set; }  // 25. Add prop

		public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()  // 31.
        {
            if (ModelState.IsValid)  // 32. if the model state is valid then ..
            {
                await _db.TheBook.AddAsync(TheBook);  // 33. add the book to the db
                await _db.SaveChangesAsync();  // 34. pushed to the db
                return RedirectToPage("Index");  // 35. redirect to the Index page
            }
            else  // 36.else
            {
                return Page(); // 37. e return to page
            }
        }
    }
}
