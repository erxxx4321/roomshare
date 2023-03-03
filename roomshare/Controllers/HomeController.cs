using Microsoft.AspNetCore.Mvc;
using roomshare.Data;
using roomshare.Models;
using System.Diagnostics;

namespace roomshare.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		DataContext _context = new DataContext();
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var houses = (from h in _context.Houses
										select h).ToList();
			return View(houses);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}