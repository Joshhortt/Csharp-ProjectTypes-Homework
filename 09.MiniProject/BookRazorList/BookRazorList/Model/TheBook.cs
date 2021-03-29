using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookRazorList.Model
{
	public class TheBook
	{
		[Key]  // 2.
		public int Id { get; set; } // 3.

		[Required] // 4.
		public string Name { get; set; }  // 5.
		public string Author { get; set; }  // 6.

	}
}
