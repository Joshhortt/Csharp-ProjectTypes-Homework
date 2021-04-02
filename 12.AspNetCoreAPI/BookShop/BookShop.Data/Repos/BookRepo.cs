using BookShop.Data.Interfaces;
using BookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 9. Create public class

namespace BookShop.Data.Repos
{
	public class BookRepo : IBookRepo
	{
		// 10. Interface Implementation
		public List<Book> GetAllBooks()
		{
			throw new NotImplementedException();
		}

		public Book GetBook(int id)
		{
			throw new NotImplementedException();
		}
	}
}
