using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class CabinType
{
    public int Id { get; set; }

    public string? CabinDescription { get; set; }

    public virtual ICollection<CabinInfo> CabinInfos { get; set; } = new List<CabinInfo>();
}
