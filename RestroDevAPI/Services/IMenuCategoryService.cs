using RestroDevAPI.DTO.MenuCategory;

namespace RestroDevAPI.Services
{
    public interface IMenuCategoryService
    {
        Task<IEnumerable<MenuCategoryDTO>> GetMenuCategoriesAsync();
        Task<MenuCategoryDTO> GetMenuCategoryAsync(int menuCategoryId);
        Task<bool> PutMenuCategoryAsync(MenuCategoryDTO menuCategoryDTO);
        Task<bool> PostMenuCategoryAsync(MenuCategoryDTO menuCategoryDTO);
        Task<bool> MenuCategoryExistsAsync(string categoryName);
        Task<bool> DeleteMenuCategoryAsync(int menuCategoryId);        
    }
}
