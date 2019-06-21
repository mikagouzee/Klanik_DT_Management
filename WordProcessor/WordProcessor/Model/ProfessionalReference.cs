using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class ProfessionalReference
    {
        public Guid Id { get; set; }
        public Guid KonsultantId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Function { get; set; }
        public string Company { get; set; }

        public virtual Konsultant Konsultant { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
