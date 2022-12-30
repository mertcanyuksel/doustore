using Microsoft.AspNetCore.Mvc;

namespace doustore.webui.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
