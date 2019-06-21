using System;
using System.Collections.Generic;

namespace WordProcessor
{
    public partial class PersonalEducation
    {
        public Guid EducationId { get; set; }
        public Guid KonsultantId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsRelevant { get; set; }

        public virtual Education Education { get; set; }
        public virtual Konsultant Konsultant { get; set; }
    }
}
