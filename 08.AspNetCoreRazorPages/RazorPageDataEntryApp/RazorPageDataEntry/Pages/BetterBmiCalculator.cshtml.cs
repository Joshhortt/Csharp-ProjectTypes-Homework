using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDataEntry.Pages
{
    public class BetterBmiCalculatorModel : PageModel
    {
        [TempData]
        public string ResultInfo { get; set; }

      
        [BindProperty]
        public double Weight { get; set; }

       
        [BindProperty]
        public double Height { get; set; }

        public void OnGet()
        {
        }

		public IActionResult OnPostCalculate()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			var result = (Weight / ((Height / 100) * (Height / 100)));

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

		public IActionResult OnPostTellPretty()
		{
			ResultInfo = "You are so hot! Time for a Pancake and calculating your BMI!";
			return RedirectToPage();
		}
	}
}
