using Microsoft.AspNetCore.Mvc;

namespace AsmApp.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
