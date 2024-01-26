using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class TableInfo
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? FloorId { get; set; }

    public int? CabinId { get; set; }

    public int? TableNo { get; set; }

    public int? Capacity { get; set; }

    public virtual BranchesInfo? Branch { get; set; }

    public virtual CabinInfo? Cabin { get; set; }

    public virtual FloorsInfo? Floor { get; set; }

    public virtual ICollection<OrderInfo> OrderInfos { get; set; } = new List<OrderInfo>();
}
