using pd311_mvc_aspnet.Models;

namespace pd311_mvc_aspnet.Repositories.Products
{
    public interface IProductRepository
        : IGenericRepository<Product, string>
    {
        IQueryable<Product> Products { get; }

        Task<bool> DeleteAsync(Product product);
        Task<string?> GetAllAsync();
        Task<IEnumerable<Product>> GetByCategoryAsync(string categoryName);
    }
}
