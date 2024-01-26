using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string? District1 { get; set; }

    public virtual ICollection<HotelRegistration> HotelRegistrations { get; set; } = new List<HotelRegistration>();
}
