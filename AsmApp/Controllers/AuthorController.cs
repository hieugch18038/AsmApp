using AsmApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AsmApp.Controllers
{
    public class AuthorController : Controller
    {
        private ApplicationDbContext context;
        public AuthorController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public IActionResult Detail()
        {
            var authors = context.Author.ToList();
            return View(authors);
        }
    }
}
