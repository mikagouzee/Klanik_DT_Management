using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class OwnedCompetence
    {
        public Guid CompetenceId { get; set; }
        public Guid KonsultantId { get; set; }
        public int Rating { get; set; }
        public bool IsRelevant { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Konsultant Konsultant { get; set; }
    }
}
