using Microsoft.EntityFrameworkCore;
using PracticeCRUD.Models;

namespace PracticeCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        

    }
}
