using Microsoft.EntityFrameworkCore;

namespace ProductApi.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;initial catalog=wheelfactory;User ID=sa;Password=Pass@123;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
