using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class HotelRegistration
{
    public int Id { get; set; }

    public string? HotelCode { get; set; }

    public string? HotelName { get; set; }

    public int? CusineType { get; set; }

    public int? City { get; set; }

    public int? District { get; set; }

    public int? State { get; set; }

    public int? Country { get; set; }

    public string? Pincode { get; set; }

    public string? Address { get; set; }

    public string? Panno { get; set; }

    public string? Gstin { get; set; }

    public string? PrimaryContactName { get; set; }

    public string? PrimaryContactNo { get; set; }

    public string? SecondaryContactName { get; set; }

    public string? SecondaryContactNo { get; set; }

    public string? SuperAdminUserName { get; set; }

    public string? SuperAdminPassword { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual ICollection<BranchesInfo> BranchesInfos { get; set; } = new List<BranchesInfo>();

    public virtual City? CityNavigation { get; set; }

    public virtual Country? CountryNavigation { get; set; }

    public virtual CusineTypeInfo? CusineTypeNavigation { get; set; }

    public virtual District? DistrictNavigation { get; set; }

    public virtual ICollection<MenuCategory> MenuCategories { get; set; } = new List<MenuCategory>();

    public virtual ICollection<OrderInfo> OrderInfos { get; set; } = new List<OrderInfo>();

    public virtual State? StateNavigation { get; set; }
}
