using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class CabinInfo
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? FloorId { get; set; }

    public int? CabinType { get; set; }

    public int? CabinNo { get; set; }

    public string? CabinName { get; set; }

    public virtual BranchesInfo? Branch { get; set; }

    public virtual CabinType? CabinTypeNavigation { get; set; }

    public virtual FloorsInfo? Floor { get; set; }

    public virtual ICollection<TableInfo> TableInfos { get; set; } = new List<TableInfo>();
}
