using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 3. Add Book class to Models

namespace BookShop.Models
{
	public class Book
	{
		// 4. Add Properties
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public int PublishYear { get; set; }
		public bool IsAvailable { get; set; }
		public string CallNumber { get; set; }
	}
}
