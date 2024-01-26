using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class StaffType
{
    public int Id { get; set; }

    public string? StaffType1 { get; set; }

    public virtual ICollection<StaffInfo> StaffInfos { get; set; } = new List<StaffInfo>();
}
