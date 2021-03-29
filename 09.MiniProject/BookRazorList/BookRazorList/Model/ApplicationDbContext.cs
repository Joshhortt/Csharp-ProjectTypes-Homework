using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRazorList.Model
{
	public class ApplicationDbContext : DbContext  // 8. 
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // 9. Constructor
		{

		}

		public DbSet<TheBook> TheBook { get; set; }  // 10.
	}
}
