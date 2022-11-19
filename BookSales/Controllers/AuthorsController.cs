using Microsoft.AspNetCore.Mvc;

namespace BookSales.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
