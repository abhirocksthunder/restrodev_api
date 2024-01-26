using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestroDevAPI.DTO;
using RestroDevAPI.DTO.MenuCategory;
using RestroDevAPI.Services;
using System.ComponentModel.Design;

namespace RestroDevAPI.Controllers
{
    [Route("api/MenuCategory")]
    [ApiController]
    public class MenuCategoryController : ControllerBase
    {
        private readonly IMenuCategoryService _menuCategoryService;
        private ResponseDTO _response;
        public MenuCategoryController(IMenuCategoryService menuCategoryService)
        {
            _menuCategoryService = menuCategoryService;
            _response = new ResponseDTO();
        }

        [HttpGet]
        [Route("check-exist/{name}")]
        public async Task<ResponseDTO> VendorRegistrationExistsAsync(string name)
        {
            try
            {
                var status = await _menuCategoryService.MenuCategoryExistsAsync(name);
                if (status)
                    _response.IsSuccess = true;
                else
                    _response.IsSuccess = false;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return _response;
            }
        }
        [HttpGet]
        [Route("get-menu-category-list")]
        public async Task<ResponseDTO> GetVendorRegistrationsAsync()
        {
            try
            {
                var menuCategoryDTOs = await _menuCategoryService.GetMenuCategoriesAsync();
                if (menuCategoryDTOs.Any())
                {
                    _response.Result = menuCategoryDTOs;
                }
                _response.IsSuccess = true;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return _response;
            }
        }
        [HttpGet]
        [Route("get-menuCategory/{menuCategoryId}")]
        public async Task<ResponseDTO> GetVendorRegistrationAsync(int menuCategoryId)
        {
            try
            {
                var menuCategoryDTO = await _menuCategoryService.GetMenuCategoryAsync(menuCategoryId);
                _response.Result = menuCategoryDTO;
                _response.IsSuccess = true;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return _response;
            }
        }
        [HttpPost]
        [Route("save")]
        public async Task<ResponseDTO> PostVendorRegistrationAsync(MenuCategoryDTO menuCategoryDTO)
        {
            try
            {
                var status = await _menuCategoryService.PostMenuCategoryAsync(menuCategoryDTO);
                if (status)
                    _response.IsSuccess = true;
                else
                    _response.IsSuccess = false;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return _response;
            }
        }
        [HttpPost]
        [Route("update")]
        public async Task<ResponseDTO> PutVendorRegistrationAsync(MenuCategoryDTO menuCategoryDTO)
        {
            try
            {
                var status = await _menuCategoryService.PutMenuCategoryAsync(menuCategoryDTO);
                if (status)
                    _response.IsSuccess = true;
                else
                    _response.IsSuccess = false;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return _response;
            }
        }

        [HttpDelete]
        [Route("delete/{menuCategoryId}")]
        public async Task<ResponseDTO> DeleteVendorRegistrationAsync(int menuCategoryId)
        {
            try
            {
                var status = await _menuCategoryService.DeleteMenuCategoryAsync(menuCategoryId);
                if (status)
                    _response.IsSuccess = true;
                else
                    _response.IsSuccess = false;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return _response;
            }
        }
    }
}
