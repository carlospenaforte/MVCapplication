using Microsoft.AspNetCore.Mvc;
using MVCapplication.Models;

namespace MVCapplication.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard" };
            return View(item);
        }
    }
}
