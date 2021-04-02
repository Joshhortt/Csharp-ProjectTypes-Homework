using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// 1. Create new ValuescONTROLER
namespace BookShop.Controllers
{
	// 2. Add Get method without parameters
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET: api/<ValuesController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2", "value3", "value4" };
		}

		// 3. Add Get method with parameter id
		// GET api/<ValuesController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value" + id;
		}
	}
}
