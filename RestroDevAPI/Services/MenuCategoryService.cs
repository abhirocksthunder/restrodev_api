using AutoMapper;
using RestroDevAPI.DTO.MenuCategory;
using RestroDevAPI.Models;
using RestroDevAPI.Repository;

namespace RestroDevAPI.Services
{
    public class MenuCategoryService : IMenuCategoryService
    {
        private readonly IMenuCategoryRepository _menuCategoryRepository;
        private readonly IMapper _mapper;
        public MenuCategoryService(IMenuCategoryRepository menuCategoryRepository, IMapper mapper)
        {
            _menuCategoryRepository = menuCategoryRepository;
            _mapper = mapper;
        }
        public async Task<bool> MenuCategoryExistsAsync(string categoryName)
        {
            return await _menuCategoryRepository.MenuCategoryExistsAsync(categoryName);
        }

        public async Task<IEnumerable<MenuCategoryDTO>> GetMenuCategoriesAsync()
        {
            var menuCategorys = await _menuCategoryRepository.GetMenuCategoriesAsync();
            return _mapper.Map<IEnumerable<MenuCategoryDTO>>(menuCategorys);

        }

        public async Task<MenuCategoryDTO> GetMenuCategoryAsync(int menuCategoryId)
        {
            var menuCategory = await _menuCategoryRepository.GetMenuCategoryAsync(menuCategoryId);            
            return _mapper.Map<MenuCategoryDTO>(menuCategory);
        }

        public async Task<bool> PostMenuCategoryAsync(MenuCategoryDTO menuCategoryDTO)
        {
            var menuCategoryEntity = _mapper.Map<MenuCategory>(menuCategoryDTO);
            
            return await _menuCategoryRepository.PostMenuCategoryAsync(menuCategoryEntity);
        }

        public async Task<bool> PutMenuCategoryAsync(MenuCategoryDTO menuCategoryDTO)
        {
            var menuCategoryEntity = _mapper.Map<MenuCategory>(menuCategoryDTO);

            return await _menuCategoryRepository.PutMenuCategoryAsync(menuCategoryEntity);
        }

        public async Task<bool> DeleteMenuCategoryAsync(int menuCategoryId)
        {
            return await _menuCategoryRepository.DeleteMenuCategoryAsync(menuCategoryId);
        }
    }
}
