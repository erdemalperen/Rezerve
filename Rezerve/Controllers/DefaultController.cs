using Microsoft.AspNetCore.Mvc;

namespace Rezerve.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
