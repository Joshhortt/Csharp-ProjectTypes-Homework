using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 5. Add a BooksController

namespace BookShop.Controllers
{
	[Route("api/[controller]")]  // /api/books
	[ApiController]
	public class BooksController : ControllerBase
	{
		public List<Book> books = new List<Book>()
		{
			new Book { Id = 1, Title = "The Man with a Skateboard", Author = "Ethan Snow", PublishYear = 2009, CallNumber = "ES01" },
			new Book { Id = 2, Title = "The Girl who is eleven", Author = "Dora Ramirez", PublishYear = 2015, CallNumber = "DR02" },
			new Book { Id = 3, Title = "Make my day", Author = "Susan Bernstein", PublishYear = 2016, CallNumber = "SB03"},
			new Book { Id = 4, Title = "The Idiot", Author = "Joel Watson", PublishYear = 2011, CallNumber = "JW04"},
			new Book { Id = 5, Title = "How to become rich", Author = "Douglas Mocca", PublishYear = 2018, CallNumber = "DM05"},
			new Book { Id = 6, Title = "Stay poor", Author = "Kyle Pine", PublishYear = 2017, CallNumber = "KP06"},
			new Book { Id = 7, Title = "Change your life waking up at 4", Author = "Jason Patel", PublishYear = 2015, CallNumber = "JP07"},
			new Book { Id = 8, Title = "The 50 minutes pomodoro strategy", Author = "Chris  Beck", PublishYear = 2017, CallNumber = "CB08"},
			new Book { Id = 9, Title = "Become a Generalist", Author = "Timothy Eisenhower", PublishYear = 2020, CallNumber = "TE09"},
			new Book { Id = 10, Title = "Know your enemy", Author = "Josh Powell", PublishYear = 2010, CallNumber = "JP10"},
		};

		// Output for all List is: https://localhost:44320/api/books 
		// Output for Id 4: https://localhost:44320/api/books/4
		// Output for Id 11: {"type":"https://tools.ietf.org/html/rfc7231#section-6.5.4","title":"Not Found","status":404,"traceId":"00-0c74d9fa31900c4896652c66d4bab460-e6e2acb5cdc63e4b-00"}

		[HttpGet]
		public ActionResult<IEnumerable<Book>> GetAllBooks()
		{
			return books;
		}

		[HttpGet("{id}")]
		public ActionResult<Book> GetBook(int id)
		{
			var book = books.FirstOrDefault(x => x.Id == id);
			if (book == null)
			{
				return NotFound();
			}
			return book;
		}
	}
}
