using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwekuO.CabsBooking.MVC.Controllers
{
    public class CabTypesController : Controller
    {
        private readonly ICabTypesService _cabTypesService;

        public CabTypesController(ICabTypesService cabTypesService)
        {
            _cabTypesService = cabTypesService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var cab = await _cabTypesService.GetCabDetails(id);
            return View(cab);
        }
    }
}
