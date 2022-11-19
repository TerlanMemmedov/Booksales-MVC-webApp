using BookSales.Data;
using BookSales.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookSales.Controllers
{
    public class PrintHousesController : Controller
    {
        private readonly AppDbContext _context;

        public PrintHousesController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allPrintHouses = await _context.PrintHouses.ToListAsync();
            return View(allPrintHouses);
        }

        public async Task<IActionResult> Details(int id)
        {
            var printHouse = await _context.PrintHouses.FirstOrDefaultAsync(p => p.Id == id);
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

            await _context.PrintHouses.AddAsync(printHouse);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int id)
        {
            var printHouse = await _context.PrintHouses.FirstOrDefaultAsync(p => p.Id == id);
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

            _context.PrintHouses.Update(printHouse);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //Get delete
        //Post delete
        

    }
}
