using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class City
{
    public int CityId { get; set; }

    public string? City1 { get; set; }

    public virtual ICollection<HotelRegistration> HotelRegistrations { get; set; } = new List<HotelRegistration>();
}
