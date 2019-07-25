using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WordProcessor.Repositories {
    public class KonsultantRepository {
        public Konsultant GetKonsultantById(Guid id)
        {
            using (KonsultantDbContext ctx = new KonsultantDbContext())
            {
                return ctx.Konsultant
                    .Include(kl => kl.KnownLanguage)
                    .ThenInclude(l => l.Language)
                   .Include(k => k.OwnedCompetence)
                       .ThenInclude(c => c.Competence)
                   .Include(k => k.PersonalEducation)
                       .ThenInclude(e => e.Education)
                   .Include(k => k.OwnedCertificate)
                       .ThenInclude(c => c.Certificate)
                   .Include(k => k.ProfessionalExperience)
                       .ThenInclude(p => p.Accomplishment)
                   .Include(k => k.ProfessionalExperience)
                       .ThenInclude(p => p.TechnicalEnvironment)
                   .Include(k => k.ProfessionalReference)
                       .ThenInclude(p => p.Contact)
                   .Include(k => k.Recruiter)
                   .FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
