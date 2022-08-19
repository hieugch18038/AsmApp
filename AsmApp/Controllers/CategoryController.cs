using Microsoft.AspNetCore.Mvc;

namespace AsmApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
