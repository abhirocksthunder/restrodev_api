using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class StaffInfo
{
    public int Id { get; set; }

    public int? StaffType { get; set; }

    public string? ContactName { get; set; }

    public string? ContactNo { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual StaffType? StaffTypeNavigation { get; set; }
}
