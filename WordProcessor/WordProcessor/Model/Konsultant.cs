using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Konsultant
    {
        public Konsultant()
        {
            KnownLanguage = new HashSet<KnownLanguage>();
            OwnedCertificate = new HashSet<OwnedCertificate>();
            OwnedCompetence = new HashSet<OwnedCompetence>();
            PersonalEducation = new HashSet<PersonalEducation>();
            ProfessionalExperience = new HashSet<ProfessionalExperience>();
            ProfessionalReference = new HashSet<ProfessionalReference>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Function { get; set; }
        public DateTime Availability { get; set; }
        public Guid? RecruiterId { get; set; }

        public virtual Recruiter Recruiter { get; set; }
        public virtual ICollection<KnownLanguage> KnownLanguage { get; set; }
        public virtual ICollection<OwnedCertificate> OwnedCertificate { get; set; }
        public virtual ICollection<OwnedCompetence> OwnedCompetence { get; set; }
        public virtual ICollection<PersonalEducation> PersonalEducation { get; set; }
        public virtual ICollection<ProfessionalExperience> ProfessionalExperience { get; set; }
        public virtual ICollection<ProfessionalReference> ProfessionalReference { get; set; }
    }
}
