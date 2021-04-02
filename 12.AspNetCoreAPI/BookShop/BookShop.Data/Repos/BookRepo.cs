using BookShop.Data.Interfaces;
using BookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Create public class

namespace BookShop.Data.Repos
{
	public class BookRepo : IBookRepo
	{
		// 13. Paste here List of books taken from BooksController
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

		// 11. Interface Implementation
		public List<Book> GetAllBooks()
		{
			return books;  // 14. Add return books
		}

		public Book GetBook(int id)
		{
			return books.FirstOrDefault(x => x.Id == id);  // 15. Add books First or default id
		}
	}
}
