using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaMenu.Models;
using PizzaMenu.Repositories;

namespace PizzaMenu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuItemRepository _menuItemRepository;

        public HomeController(ILogger<HomeController> logger, IMenuItemRepository menuItemRepository)
        {
            _logger = logger;
            _menuItemRepository = menuItemRepository;
        }

        public IActionResult Index()
        {
            return View(_menuItemRepository.GetItems());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetWaitTimes([FromBody]int id)
        {
            return new JsonResult(_menuItemRepository.ItemWaitTime(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
