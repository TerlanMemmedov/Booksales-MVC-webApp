using BookSales.Models;
using Microsoft.EntityFrameworkCore;

namespace BookSales.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PrintHouse> PrintHouses { get; set; }
        public DbSet<Translator> Translators { get; set; }

        //relations and orders part will be added
    }
}
