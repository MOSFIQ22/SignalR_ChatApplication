using Microsoft.AspNetCore.Mvc;

namespace Messaging_with_FileSharing_Software.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
