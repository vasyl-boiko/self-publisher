using Microsoft.AspNetCore.Mvc;

namespace SelfPublisher.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
