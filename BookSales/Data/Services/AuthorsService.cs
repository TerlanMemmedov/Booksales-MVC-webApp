using BookSales.Data.Base;
using BookSales.Models;

namespace BookSales.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author> , IAuthorsService
    {
        public AuthorsService(AppDbContext context) : base(context)
        {

        }
    }
}
