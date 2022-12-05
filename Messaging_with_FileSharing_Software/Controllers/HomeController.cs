using Microsoft.AspNetCore.Mvc;

namespace Messaging_with_FileSharing_Software.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
