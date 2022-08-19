using AsmApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Detail(int id)
        {
            var authors = context.Author.Include(a =>a.Books).ThenInclude(b => b.Category).FirstOrDefault(a => a.Id == id);
            return View(authors);
        }
    }
}
