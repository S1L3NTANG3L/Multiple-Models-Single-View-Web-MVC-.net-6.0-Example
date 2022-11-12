namespace Resume.Models
{
    public class BigOne
    {
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<PersonalInfo> PersonalInfos { get; set; }
        public Education Education { get; set; }
        public Experience Experience { get; set; }
        public Skill Skill { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
