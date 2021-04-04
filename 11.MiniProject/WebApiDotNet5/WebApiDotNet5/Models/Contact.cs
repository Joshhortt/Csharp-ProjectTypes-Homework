using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNet5.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NichName { get; set; }
		public DateTime DateCreated { get; set; }
		public bool IsDeleted { get; set; }
	}
}
