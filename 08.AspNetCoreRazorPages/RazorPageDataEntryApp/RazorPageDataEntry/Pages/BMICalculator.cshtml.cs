using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPageDataEntry.Pages
{
    public class BMICalculatorModel : PageModel
    {
        [TempData]
        public string ResultInfo { get; set; }

       
        [BindProperty]
        public int Weight { get; set; }
        
        [BindProperty]
        public int Height { get; set; }

        public void OnGet()
        {
        }
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			float result = (Weight / (((float)Height / 100) * ((float)Height / 100)));

			if (result < 18.5)
			{
				ResultInfo = $"You are Underweight (BMI: {result})! Time to eat a few Pancakes!";
			}
			else if (result < 24.9)
			{
				ResultInfo = $"You are Normal weight (BMI: {result})! It's OK to eat a bunch of Pancakes!";
			}
			else if (result < 29.9)
			{
				ResultInfo = $"You are Overweight (BMI: {result})! But never heard of anybody who died because of eating a few Pancakes?";
			}
			else
			{
				ResultInfo = $"You are Obese (BMI: {result})! OK, just one Pancake before going under a strict diet?";
			}

			return RedirectToPage();
		}
	}
}
