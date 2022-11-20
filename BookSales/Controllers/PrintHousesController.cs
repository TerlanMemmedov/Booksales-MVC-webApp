using BookSales.Data;
using BookSales.Data.Base;
using BookSales.Data.Services;
using BookSales.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookSales.Controllers
{
    public class PrintHousesController : Controller
    {
        private readonly IPrintHousesService _service;

        public PrintHousesController(IPrintHousesService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var printHouses = await _service.GetAllAsync();
            return View(printHouses);
        }

        public async Task<IActionResult> Details(int id)
        {
            var printHouse = await _service.GetByIdAsync(id);
            if (printHouse is null)
            {
                return View("NotFound");
            }
            return View(printHouse);
        }


        //get
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, PictureUrl, About")] PrintHouse printHouse)
        {
            if (!ModelState.IsValid)
            {
                return View(printHouse);
            }

            await _service.AddAsync(printHouse);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int id)
        {
            var printHouse = await _service.GetByIdAsync(id);
            if (printHouse is null)
            {
                return View("NotFound");
            }
            return View(printHouse);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id ,Name, PictureUrl, About")] PrintHouse printHouse)
        {
            if (!ModelState.IsValid)
            {
                return View(printHouse);
            }

            await _service.UpdateAsync(id, printHouse);
            return RedirectToAction("Index");
        }

        //Get delete
        public async Task<IActionResult> Delete(int id)
        {
            var printHouse = await _service.GetByIdAsync(id);
            if (printHouse is null)
            {
                return View("NotFound");
            }
            return View(printHouse);
        }

        //Post delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var printHouse = await _service.GetByIdAsync(id);

            if (printHouse is null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
