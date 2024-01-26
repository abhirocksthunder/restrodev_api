using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? Item { get; set; }

    public int? Quantity { get; set; }

    public bool? IsItemServed { get; set; }

    public virtual OrderInfo? Order { get; set; }
}
