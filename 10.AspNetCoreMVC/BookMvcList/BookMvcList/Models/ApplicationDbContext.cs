using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvcList.Models
{
	// 3. Create Class in Models
	public class ApplicationDbContext  : DbContext  // 6. Add Inheritance from DbConetxt
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  // 4. Constructor
		{

		}

		public DbSet<TheBook> Books { get; set; }  // 5. Add property Book to the Db
	}
}
