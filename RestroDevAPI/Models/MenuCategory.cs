using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class MenuCategory
{
    public int Id { get; set; }

    public int? HotelId { get; set; }

    public int? BranchId { get; set; }

    public string? CategoryName { get; set; }

    public bool? Status { get; set; }

    public virtual BranchesInfo? Branch { get; set; }

    public virtual HotelRegistration? Hotel { get; set; }

    public virtual ICollection<MainMenu> MainMenus { get; set; } = new List<MainMenu>();
}
