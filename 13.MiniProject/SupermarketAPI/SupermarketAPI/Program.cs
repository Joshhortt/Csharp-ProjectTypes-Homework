// 13. C # Project Types - Homework - Mini-Project - ASP .NET Core API
// Build a Web API application with two Get or Post Commands.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Supermarket.API;
using SupermarketAPI.Persistence.Contexts;

namespace SupermarketAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();


			using (var scope = host.Services.CreateScope())
			using (var context = scope.ServiceProvider.GetService <AppDbContext>()) 
			{
				context.Database.EnsureCreated();
			}
			host.Run();
		}


		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
