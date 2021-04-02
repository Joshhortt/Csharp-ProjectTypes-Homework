using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 6. Add Book class to Models

namespace BookShop.Data.Models
{
	public class Book
	{
		// 7. Add Properties
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public int PublishYear { get; set; }
		public bool IsAvailable { get; set; }
		public string CallNumber { get; set; }
	}
}
