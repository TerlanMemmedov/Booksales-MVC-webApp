using BookSales.Data.Base;
using BookSales.Models;

namespace BookSales.Data.Services
{
    public class TranslatorsService : EntityBaseRepository<Translator>, ITranslatorsService
    {
        public TranslatorsService(AppDbContext context) : base(context)
        {

        }
    }
}
