using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<HotelRegistration> HotelRegistrations { get; set; } = new List<HotelRegistration>();
}
