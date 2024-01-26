namespace RestroDevAPI.DTO.MenuCategory
{
    public class MenuCategoryDTO
    {
        public int Id { get; set; }

        public int? HotelId { get; set; }

        public int? BranchId { get; set; }

        public string? CategoryName { get; set; }
        public bool? Status { get; set; }
    }
}
