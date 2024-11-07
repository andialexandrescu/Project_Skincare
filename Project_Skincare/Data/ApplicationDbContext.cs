using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Skincare.Models;

namespace Project_Skincare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // definire relatii cu modelele Category si Product (CategoryId FK in Products)
            modelBuilder.Entity<Product>()
            .HasOne<Category>(a => a.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(a => a.CategoryId);
            // relatie intre Product si Review (ProductId FK in Reviews) 
            modelBuilder.Entity<Review>()
            .HasOne<Product>(a => a.Product)
            .WithMany(c => c.Reviews)
            .HasForeignKey(a => a.ProductId);
        }

    }
}
