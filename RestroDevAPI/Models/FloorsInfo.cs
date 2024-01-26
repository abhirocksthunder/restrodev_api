using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class FloorsInfo
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? FloorNo { get; set; }

    public string? FloorName { get; set; }

    public virtual BranchesInfo? Branch { get; set; }

    public virtual ICollection<CabinInfo> CabinInfos { get; set; } = new List<CabinInfo>();

    public virtual ICollection<TableInfo> TableInfos { get; set; } = new List<TableInfo>();
}
