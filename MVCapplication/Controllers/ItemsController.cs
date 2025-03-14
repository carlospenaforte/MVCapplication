using Microsoft.AspNetCore.Mvc;
using MVCapplication.Models;

namespace MVCapplication.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard" };
            return View(item);
        }
    }
}
