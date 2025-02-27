using pd311_mvc_aspnet.Models;

namespace pd311_mvc_aspnet.Repositories.Categories
{
    public interface ICategoryRepository : IGenericRepository<Category, string>
    {
        IQueryable<Category> Categories { get; }
        Task<Category?> FindByNameAsync(string name);
        Task<Category?> FindByIdAsync(string id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task AddAsync(Category model);
        Task DeleteAsync(Category category);
    }
}
