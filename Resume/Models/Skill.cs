using System;
using System.Collections.Generic;

namespace Resume.Models
{

    public partial class Skill
    {
        public int SkillsId { get; set; }

        public string? Name { get; set; }

        public int? Rating { get; set; }
    }
}