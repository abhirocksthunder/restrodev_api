using RestroDevAPI.Models;

namespace RestroDevAPI.Repository
{
    public interface IMenuCategoryRepository
    {
        Task<IEnumerable<MenuCategory>> GetMenuCategoriesAsync();
        Task<MenuCategory> GetMenuCategoryAsync(int menuCategoryId);
        Task<bool> PutMenuCategoryAsync(MenuCategory menuCategory);
        Task<bool> PostMenuCategoryAsync(MenuCategory menuCategory);
        Task<bool> MenuCategoryExistsAsync(string categoryName);
        Task<bool> DeleteMenuCategoryAsync(int menuCategoryId);
    }
}
