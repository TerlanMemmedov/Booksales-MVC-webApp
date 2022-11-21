using BookSales.Data.Base;
using BookSales.Models;

namespace BookSales.Data.Services
{
    public interface IAuthorsService : IEntityBaseRepository<Author>
    {
    }
}
