using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class BranchesInfo
{
    public int Id { get; set; }

    public int? HotelId { get; set; }

    public string? HotelCode { get; set; }

    public string? BranchNo { get; set; }

    public string? BranchName { get; set; }

    public string? BranchAddress { get; set; }

    public virtual ICollection<CabinInfo> CabinInfos { get; set; } = new List<CabinInfo>();

    public virtual ICollection<FloorsInfo> FloorsInfos { get; set; } = new List<FloorsInfo>();

    public virtual HotelRegistration? Hotel { get; set; }

    public virtual ICollection<MenuCategory> MenuCategories { get; set; } = new List<MenuCategory>();

    public virtual ICollection<OrderInfo> OrderInfos { get; set; } = new List<OrderInfo>();

    public virtual ICollection<TableInfo> TableInfos { get; set; } = new List<TableInfo>();
}
