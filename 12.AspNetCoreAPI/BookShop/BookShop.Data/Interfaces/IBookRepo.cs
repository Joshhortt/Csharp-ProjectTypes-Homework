using BookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7. Create public Inteface

namespace BookShop.Data.Interfaces
{
	public interface IBookRepo
	{
		// 8. Add 
		List<Book> GetAllBooks();
		Book GetBook(int id);
	}
}
