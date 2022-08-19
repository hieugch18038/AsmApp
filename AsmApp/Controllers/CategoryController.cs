using AsmApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AsmApp.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Detail(int id)
        {
            var category = context.Category.Include(c => c.Books).ThenInclude(b => b.Author).FirstOrDefault(c => c.Id == id);
            return View();
        }
    }
}
