using System;
using System.Collections.Generic;

namespace Resume.Models;

public partial class PersonalInfo
{
    public int PerId { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Contact { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string About { get; set; } = null!;
}
