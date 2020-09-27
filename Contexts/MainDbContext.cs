namespace Onebrb.Data.Contexts
{
    using Microsoft.EntityFrameworkCore;
    using Onebrb.Data.Entities;

    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
