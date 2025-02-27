using Microsoft.EntityFrameworkCore;
using pd311_mvc_aspnet.Data;
using pd311_mvc_aspnet.Models;

namespace pd311_mvc_aspnet.Repositories.Products
{
    public class ProductRepository
        : GenericRepository<Product, string>, IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products.Include(p => p.Category);

        public Task<bool> DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(string categoryName)
        {
            return await Products
                .Where(p => p.Category != null && p.Category.Name != null &&
                            p.Category.Name.ToLower() == categoryName.ToLower())
                .ToListAsync();
        }
    }
}
