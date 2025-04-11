
using ECommerceApi2.Models.ECommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Data
    {
    public class ElectronicsDbContext : DbContext
    {
        public ElectronicsDbContext(DbContextOptions<ElectronicsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
