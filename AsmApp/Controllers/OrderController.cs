using Microsoft.AspNetCore.Mvc;

namespace AsmApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
