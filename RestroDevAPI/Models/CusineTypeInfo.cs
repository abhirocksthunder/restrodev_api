using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class CusineTypeInfo
{
    public int Id { get; set; }

    public string? CusineType { get; set; }

    public virtual ICollection<HotelRegistration> HotelRegistrations { get; set; } = new List<HotelRegistration>();
}
