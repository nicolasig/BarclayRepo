using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BarclayServer.Models;

namespace BarclayServer.Controllers
{

    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TestController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //https://localhost:7280/api/Test/GetUserNotifications/

        [HttpGet("[action]")]
        public void GetUserNotifications()
        {
            Console.WriteLine("Serve Nicoooo");
            //return 89;
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