using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Competence
    {
        public Competence()
        {
            OwnedCompetence = new HashSet<OwnedCompetence>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OwnedCompetence> OwnedCompetence { get; set; }
    }
}
