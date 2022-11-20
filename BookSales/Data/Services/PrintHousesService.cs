using BookSales.Data.Base;
using BookSales.Models;

namespace BookSales.Data.Services
{
    public class PrintHousesService : EntityBaseRepository<PrintHouse>, IPrintHousesService
    {
        public PrintHousesService(AppDbContext context) : base(context)
        {
        }
    }
}
