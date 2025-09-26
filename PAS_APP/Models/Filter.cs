using System;
using System.Collections.Generic;

namespace PAS_APP.Models;

public partial class Filter
{
    public string FilterId { get; set; } = null!;

    public int ServiceId { get; set; }

    public int UserId { get; set; }

    public DateTime CreateAt { get; set; }

    public string? FileName { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
