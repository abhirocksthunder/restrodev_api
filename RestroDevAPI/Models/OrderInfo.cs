using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class OrderInfo
{
    public int Id { get; set; }

    public int? HotelId { get; set; }

    public int? BranchId { get; set; }

    public string? OrderNo { get; set; }

    public int? TableId { get; set; }

    public int? NoOfItems { get; set; }

    public string? TotalPrice { get; set; }

    public bool? IsServed { get; set; }

    public bool? IsBilled { get; set; }

    public virtual BranchesInfo? Branch { get; set; }

    public virtual HotelRegistration? Hotel { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual TableInfo? Table { get; set; }
}
