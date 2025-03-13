    using Microsoft.AspNetCore.Mvc;

namespace MVCapplication.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
