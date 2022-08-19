using AsmApp.Data;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Store()
        {
            return View(context.Book.ToList());
        }
    }
}
