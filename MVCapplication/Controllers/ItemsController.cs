using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCapplication.Data;
using MVCapplication.Models;

namespace MVCapplication.Controllers
{
    public class ItemsController : Controller
    {
        private readonly MyAppContext _context;
        public ItemsController(MyAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _context.Items.ToListAsync();
            return View(item);   
        }
    }
}
