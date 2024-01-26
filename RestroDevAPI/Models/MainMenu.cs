using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class MainMenu
{
    public int Id { get; set; }

    public int? MenuCategoryId { get; set; }

    public string? MenuName { get; set; }

    public bool? IsVeg { get; set; }

    public bool? IsEgg { get; set; }

    public bool? IsSpicy { get; set; }

    public virtual MenuCategory? MenuCategory { get; set; }

    public virtual ICollection<SubMenu> SubMenus { get; set; } = new List<SubMenu>();
}
