using AutoMapper;
using RestroDevAPI.DTO.MenuCategory;
using RestroDevAPI.Models;

namespace RestroDevAPI.Mapper
{
    public class EntityToDTOMapping : Profile
    {
        public EntityToDTOMapping() 
        {
            CreateMap<MenuCategory, MenuCategoryDTO>();
        }
    }
}
