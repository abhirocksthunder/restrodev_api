using System;
using System.Collections.Generic;

namespace RestroDevAPI.Models;

public partial class State
{
    public int StateId { get; set; }

    public string? State1 { get; set; }

    public virtual ICollection<HotelRegistration> HotelRegistrations { get; set; } = new List<HotelRegistration>();
}
