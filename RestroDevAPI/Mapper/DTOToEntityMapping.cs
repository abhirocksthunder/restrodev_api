using AutoMapper;
using RestroDevAPI.DTO.MenuCategory;
using RestroDevAPI.Models;

namespace RestroDevAPI.Mapper
{
    public class DTOToEntityMapping : Profile
    {
        public DTOToEntityMapping() 
        {
            CreateMap<MenuCategoryDTO,MenuCategory>();
        }
    }
}
