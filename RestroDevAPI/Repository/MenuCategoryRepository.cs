using Microsoft.EntityFrameworkCore;
using RestroDevAPI.Exceptions;
using RestroDevAPI.Models;

namespace RestroDevAPI.Repository
{
    public class MenuCategoryRepository : IMenuCategoryRepository
    {
        private readonly RestroDevContext _db;
        public MenuCategoryRepository(RestroDevContext db)
        {
            _db = db;
        }
        public async Task<bool> MenuCategoryExistsAsync(string name)
        {
            return await _db.MenuCategories.CountAsync(e => e.CategoryName.Equals(name)) > 0;
        }

        public async Task<IEnumerable<MenuCategory>> GetMenuCategoriesAsync()
        {
            return await _db.MenuCategories.OrderByDescending(r => r.Id).ToListAsync();
        }

        public async Task<MenuCategory> GetMenuCategoryAsync(int menuCategoryId)
        {
            return await _db.MenuCategories.FindAsync(menuCategoryId);
        }

        public async Task<bool> PostMenuCategoryAsync(MenuCategory menuCategory)
        {
            _db.MenuCategories.Add(menuCategory);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> PutMenuCategoryAsync(MenuCategory menuCategory)
        {
            var menuCategoryEntity = await _db.MenuCategories.AsNoTracking().FirstOrDefaultAsync(a => a.Id == menuCategory.Id);
            if (menuCategoryEntity == null) throw new Exception("Menu Category Not Found");
            
            _db.Entry(menuCategory).State = EntityState.Modified;
            return await _db.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteMenuCategoryAsync(int id)
        {
            MenuCategory menuCategory = await _db.MenuCategories.FindAsync(id);
            if (menuCategory == null)
            {
                throw new NotFoundException($"Expenditure Head not found for Id: {id}");
            }
            _db.Entry(menuCategory).State = EntityState.Modified;
            return await _db.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
