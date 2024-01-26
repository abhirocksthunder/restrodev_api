using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class SubMenu
{
    public int Id { get; set; }

    public int? MainMenuId { get; set; }

    public string? MenuName { get; set; }

    public string? Description { get; set; }

    public string? Price { get; set; }

    public virtual MainMenu? MainMenu { get; set; }
}
