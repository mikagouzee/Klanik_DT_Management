using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class OwnedCertificate
    {
        public Guid CertificateId { get; set; }
        public Guid KonsultantId { get; set; }
        public DateTime Obtension { get; set; }
        public DateTime? EndOfValidity { get; set; }
        public bool IsRelevant { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Konsultant Konsultant { get; set; }
    }
}
