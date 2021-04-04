using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDotNet5.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDotNet5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{

		private List<Contact> contacts = new List<Contact>
		{
			new Contact { Id = 1, FirstName = "Pedro", LastName = "Silva", NickName = "Pedra", Place = "Lisbon"},
			new Contact { Id = 1, FirstName = "Sonia", LastName = "Costa", NickName = "Soninha", Place = "Beja"}
		};

		// GET: api/<ContactController>
		[HttpGet]
		public IEnumerable<Contact> Get()
		{
			return contacts;
		}

		// GET api/<ContactController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ContactController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<ContactController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ContactController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
