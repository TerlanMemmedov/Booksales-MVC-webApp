using BookSales.Data.Services;
using BookSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSales.Controllers
{
    public class TranslatorsController : Controller
    {
        private readonly ITranslatorsService _service;

        public TranslatorsController(ITranslatorsService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            var translators = _service.GetAllAsync();
            return View(translators);
        }

        public async Task<IActionResult> Details(int id)
        {
            var translator = await _service.GetByIdAsync(id);
            if (translator is null)
            {
                return View("NotFound");
            }
            return View(translator);
        }

        //get action
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, PictureUrl, Bio")] Translator translator)
        {
            if (!ModelState.IsValid)
            {
                return View(translator);
            }
            await _service.AddAsync(translator);
            return RedirectToAction("Index");
        }


        //get action
        public async Task<IActionResult> Edit(int id)
        {
            var translator = await _service.GetByIdAsync(id);
            if (translator is null)
            {
                return View("NotFound");
            }
            return View(translator);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, PictureUrl, Bio")] Translator translator)
        {
            if (!ModelState.IsValid)
            {
                return View(translator);
            }
            await _service.UpdateAsync(id, translator);
            return RedirectToAction("Index");
        }


        //get action
        public async Task<IActionResult> Delete(int id)
        {
            var translator = await _service.GetByIdAsync(id);
            if (translator is null)
            {
                return View("NotFound");
            }
            return View(translator);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var translator = await _service.GetByIdAsync(id);
            if (translator is null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
