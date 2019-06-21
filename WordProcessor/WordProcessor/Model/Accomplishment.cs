using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Accomplishment
    {
        public Guid Id { get; set; }
        public Guid ProfessionalExperienceId { get; set; }
        public bool IsRelevant { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        public virtual ProfessionalExperience ProfessionalExperience { get; set; }
    }
}
