using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.EntityFramework
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
