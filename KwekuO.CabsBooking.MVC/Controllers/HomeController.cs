using ApplicationCore.ServiceInterfaces;
using KwekuO.CabsBooking.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KwekuO.CabsBooking.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICabTypesService _cabTypesService;

        public HomeController(ICabTypesService cabTypesService)
        {
            _cabTypesService = cabTypesService;

        }

        public async Task<IActionResult> Index()
        {
            var cabTypes = await _cabTypesService.GetAllCabTypes();
            return View(cabTypes);
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
