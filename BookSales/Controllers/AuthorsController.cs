using BookSales.Data.Services;
using BookSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSales.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsService _service;

        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _service.GetAllAsync();
            return View(authors);
        }


        public async Task<IActionResult> Details(int id)
        {
            var author = await _service.GetByIdAsync(id);
            if (author is null)
            {
                return View("NotFound");
            }
            return View(author);
        }


        //get
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, PictureUrl, Bio")] Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            await _service.AddAsync(author);
            return RedirectToAction("Index");
        }


        //get
        public async Task<IActionResult> Edit(int id)
        {
            var author = _service.GetByIdAsync(id);
            if (author is null)
            {
                return View("NotFound");
            }
            return View(author);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, PictureUrl, Bio")] Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            await _service.UpdateAsync(id, author);
            return RedirectToAction("Index");
        }


        //get
        public async Task<IActionResult> Delete(int id)
        {
            var author = _service.GetByIdAsync(id);
            if (author is null) 
            {
                return View("NotFound");
            }
            return View(author);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var author = await _service.GetByIdAsync(id);
            if (author is null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
