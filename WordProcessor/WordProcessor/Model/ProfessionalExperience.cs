using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class ProfessionalExperience
    {
        public ProfessionalExperience()
        {
            Accomplishment = new HashSet<Accomplishment>();
            TechnicalEnvironment = new HashSet<TechnicalEnvironment>();
        }

        public Guid Id { get; set; }
        public Guid KonsultantId { get; set; }
        public string Position { get; set; }
        public string Context { get; set; }
        public string Summary { get; set; }
        public string Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsRelevant { get; set; }

        public virtual Konsultant Konsultant { get; set; }
        public virtual ICollection<Accomplishment> Accomplishment { get; set; }
        public virtual ICollection<TechnicalEnvironment> TechnicalEnvironment { get; set; }
    }
}
