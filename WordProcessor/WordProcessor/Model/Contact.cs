using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Contact
    {
        public Contact()
        {
            Recruiter = new HashSet<Recruiter>();
        }

        public Guid Id { get; set; }
        public Guid ProfessionalReferenceId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public virtual ProfessionalReference ProfessionalReference { get; set; }
        public virtual ICollection<Recruiter> Recruiter { get; set; }
    }
}
