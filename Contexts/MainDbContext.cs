namespace Onebrb.Data.Contexts
{
    using Microsoft.EntityFrameworkCore;

    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
