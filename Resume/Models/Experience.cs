using System;
using System.Collections.Generic;

namespace Resume.Models;

public partial class Experience
{
    public int ExpId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? ReferenceContact { get; set; }
}
