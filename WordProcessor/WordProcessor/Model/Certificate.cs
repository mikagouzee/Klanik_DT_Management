using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Certificate
    {
        public Certificate()
        {
            OwnedCertificate = new HashSet<OwnedCertificate>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OwnedCertificate> OwnedCertificate { get; set; }
    }
}
