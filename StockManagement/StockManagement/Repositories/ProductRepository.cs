using Microsoft.EntityFrameworkCore;
using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository()
        {
            var connectionstring = "Host=localhost;Port=5432;Database=StockDatabase;Username=postgres;Password=82Iekiek!";
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseNpgsql(connectionstring);
            _context = new AppDbContext(optionBuilder.Options);
        }

        public Product CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

    }
}

