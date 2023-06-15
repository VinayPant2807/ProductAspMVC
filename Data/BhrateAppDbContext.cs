using BhrateApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BhrateApp.Data
{
    public class BhrateAppDbContext : DbContext
    {
        public BhrateAppDbContext()
        {

        }
        public BhrateAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category_Master> Category_Masters { get; set; }

        public DbSet<Product_Master> Product_Masters {get; set; } 

    }
}
