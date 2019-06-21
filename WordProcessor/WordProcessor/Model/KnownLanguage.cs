using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class KnownLanguage
    {
        public Guid LanguageId { get; set; }
        public Guid KonsultantId { get; set; }
        public int Fluency { get; set; }
        public bool IsRelevant { get; set; }

        public virtual Konsultant Konsultant { get; set; }
        public virtual Language Language { get; set; }
    }
}
