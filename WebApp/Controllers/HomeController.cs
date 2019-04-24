using Microsoft.AspNetCore.Mvc;
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
            return Redirect(nameof(disatpn19));
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
    }
}
