using BusTicket.Core.Abstract.IExternal.OBilet;
using BusTicket.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BusTicket.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetSessionService _getSessionService;
        private readonly IGetBusLocationsService _getBusLocationsService;
        public HomeController(ILogger<HomeController> logger, IGetSessionService getSessionService, IGetBusLocationsService getBusLocationsService)
        {
            _logger = logger;
            _getSessionService = getSessionService;
            _getBusLocationsService = getBusLocationsService;
        }

        public IActionResult Index()
        {
            var d = _getBusLocationsService.GetBusLocations(new Core.Dto.GetBusLocations.Request.GetBusLocationsRequest());
            var s = _getSessionService.GetSession(new Core.Dto.GetSession.Request.GetSessionRequest());
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