﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return Redirect(nameof(vssatpn19));
        }

        [Route("Heartbeat")]
        public IActionResult Heartbeat()
        {
            return View();
        }

        [Route("disatpn19")]
        public IActionResult disatpn19()
        {
            return View();
        }

        [Route("iotsatpn19")]
        public IActionResult iotsatpn19()
        {
            return View();
        }

        [Route("azuresatpn19")]
        public IActionResult azuresatpn19()
        {
            return View();
        }

        [Route("vssatpn19")]
        public IActionResult vssatpn19()
        {
            return View();
        }

        [Route("disatpn20")]
        public IActionResult disatpn20()
        {
            return View();
        }
    }
}
