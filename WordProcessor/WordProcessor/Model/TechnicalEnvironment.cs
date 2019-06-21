using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class TechnicalEnvironment
    {
        public Guid Id { get; set; }
        public Guid ProfessionalExperienceId { get; set; }
        public bool IsRelevant { get; set; }
        public string Name { get; set; }
        public string Option { get; set; }

        public virtual ProfessionalExperience ProfessionalExperience { get; set; }
    }
}
