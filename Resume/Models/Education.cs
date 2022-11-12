using System;
using System.Collections.Generic;

namespace Resume.Models;

public partial class Education
{
    public int EduId { get; set; }

    public string SchoolName { get; set; } = null!;

    public int QualifiedYear { get; set; }
}
