using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DI.Class13.FirstMVCProject.Sir.Models;
using DI.Class13.FirstMVCProject.Sir.Services;

namespace DI.Class13.FirstMVCProject.Sir.Controllers
{
    public class HomeController : Controller
    {
        private IWelcome2Service _service;

        public HomeController(IWelcome2Service service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var model = _service.WelcomeMessage();
            return View(model);
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
