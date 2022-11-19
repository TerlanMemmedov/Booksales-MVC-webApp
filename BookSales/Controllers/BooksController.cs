using Microsoft.AspNetCore.Mvc;

namespace BookSales.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
