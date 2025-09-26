using System;
using System.Collections.Generic;

namespace PAS_APP.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string Title { get; set; } = null!;

    public string? Detail { get; set; }

    public DateTime CreateAt { get; set; }
}
