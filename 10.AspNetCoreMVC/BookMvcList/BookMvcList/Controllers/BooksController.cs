using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 15. Create a new Controller + F5 to test it. Next we need to add a View - right-click Index and add view.
namespace BookMvcList.Controllers
{
	public class BooksController : Controller
	{
		public IActionResult Index()  // 16. Right-click over Index and add a razor view called Index.
		{
			return View();
		}
	}
}
