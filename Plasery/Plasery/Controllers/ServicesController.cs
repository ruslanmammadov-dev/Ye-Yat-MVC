using Microsoft.AspNetCore.Mvc;

namespace Plasery.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
