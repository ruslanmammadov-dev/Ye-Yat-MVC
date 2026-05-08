using Microsoft.AspNetCore.Mvc;

namespace Plasery.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
