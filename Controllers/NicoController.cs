using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using BarclayServer.Models;

using System.Text.Json;

namespace BarclayServer.Controllers
{

    //[Area("HumanResources")]
    public class NicoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public NicoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //https://localhost:7280/Nico/GetUserNotifications/
        [HttpGet]
        public int GetUserNotifications()
        {
            Console.WriteLine("Serve Nicoooo");
            return 89;
        }

        [HttpGet]
        public ActionResult GetPlayer()
        {
            Console.WriteLine("Get Player - NicoController");

            Player nico = BuildPlayer();


            var json = JsonSerializer.Serialize(nico);
            Console.WriteLine(json);

            // var weatherForecast = new
            // {
            //     Date = DateTime.Parse("2019-08-01"),
            //     TemperatureCelsius = 25,
            //     Summary = "Hot"
            // };



            return Ok(json);
        }

        private Player BuildPlayer()
        {
            Player jugador = new Player("Nico");

            jugador.Number = 4;
            jugador.Status = PlayerStatus.Healthy;
            jugador.Positions.Add(PlayerPositions.Defender);
            jugador.Positions.Add(PlayerPositions.Midfielder);

            return jugador;
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