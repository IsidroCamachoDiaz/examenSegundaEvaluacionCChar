using csi21_icamiaz.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csi21_icamiaz.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ExaDosContext ges;

		public HomeController(ILogger<HomeController> logger, ExaDosContext ges)
		{
			_logger = logger;
			this.ges = ges;
			Main.Principal(ges);
		}

		public IActionResult Index()
		{
			return View();
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