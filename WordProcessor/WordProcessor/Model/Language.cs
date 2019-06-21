using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class Language
    {
        public Language()
        {
            KnownLanguage = new HashSet<KnownLanguage>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<KnownLanguage> KnownLanguage { get; set; }
    }
}
