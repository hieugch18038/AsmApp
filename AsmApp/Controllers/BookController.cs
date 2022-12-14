using AsmApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AsmApp.Controllers
{
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public IActionResult Index()
        {
            var books = context.Book.ToList();
            return View(books);
        }
        public IActionResult Detail(int id)
        {
            var books = context.Book.Include(b => b.Category).Include(b => b.Author).FirstOrDefault(b => b.Id == id);
            return View(books);
        }
    }
}
