using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Education
    {
        public Education()
        {
            PersonalEducation = new HashSet<PersonalEducation>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PersonalEducation> PersonalEducation { get; set; }
    }
}
