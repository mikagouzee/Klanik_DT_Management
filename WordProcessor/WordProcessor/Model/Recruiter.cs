using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Recruiter
    {
        public Recruiter()
        {
            Konsultant = new HashSet<Konsultant>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid? ContactId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ICollection<Konsultant> Konsultant { get; set; }
    }
}
