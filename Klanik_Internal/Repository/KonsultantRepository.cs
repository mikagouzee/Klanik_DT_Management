using Klanik_Internal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Klanik_Internal.Repository {
    public class KonsultantRepository : Repository<Konsultant> {
        private readonly IList<Expression<Func<Konsultant, object>>> _modifiers;

        public KonsultantRepository(IServiceProvider provider) : base(provider)
        {
            _modifiers = new List<Expression<Func<Konsultant, object>>>();
        }

        public override void Create(Konsultant toCreate)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                var exists = _context.Konsultants.Any(x => x.Id == toCreate.Id);

                if (exists)
                {
                    Update(toCreate);
                }
                else
                {
                    _context.Add(toCreate);
                }

                _context.SaveChanges();
            }
        }

        //public void Delete(Konsultant toRemove)
        //{
        //    using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        //    {
        //        KlanikContext _context = _provider.GetService<KlanikContext>();

        //        _context.Entry(toRemove).State = EntityState.Deleted;
        //        _context.SaveChanges();
        //    }
        //}

        //public IEnumerable<Konsultant> GetAll()
        //{
        //    using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        //    {
        //        KlanikContext _context = _provider.GetService<KlanikContext>();

        //        return _context.Konsultants
        //            .ToList();
        //    }
        //}

        //public Konsultant GetById(Guid id)
        //{
        //    using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        //    {
        //        KlanikContext _context = _provider.GetService<KlanikContext>();

        //        return _context.Konsultants
        //            .Include(k => k.Languages)
        //                .ThenInclude(l => l.Language)
        //            .Include(k => k.Competences)
        //                .ThenInclude(c => c.Competence)
        //            .Include(k => k.Educations)
        //                .ThenInclude(e => e.Education)
        //            .Include(k => k.Certificates)
        //                .ThenInclude(c => c.Certificate)
        //            .Include(k => k.ProfessionalExperiences)
        //                .ThenInclude(p => p.Accomplishments)
        //            .Include(k => k.ProfessionalExperiences)
        //                .ThenInclude(p => p.TechnicalEnvironments)
        //            .Include(k => k.ProfessionalReferences)
        //                .ThenInclude(p => p.Contacts)
        //            .Include(k => k.Recruiter)
        //            .Include(k => k.Mobilites)
        //                .ThenInclude(ctn => ctn.BU)
        //                    .ThenInclude(bu => bu.Contry)
        //            .FirstOrDefault(x => x.Id == id);
        //    }
        //}

        //public IRepository<Konsultant> Include(Expression<Func<Konsultant, object>> path)
        //{
        //    _modifiers.Add(path);

        //    return this;
        //}

        public override void Update(Konsultant toEdit)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                _context.Entry(toEdit).State = EntityState.Modified;

                foreach (var item in toEdit.Mobilites)
                {
                    CreateOrUpdateMobility(_context, item);
                }
                foreach (var comp in toEdit.Competences)
                {
                    CreateOrUpdateCompetence(_context, comp);
                }

                foreach (var edu in toEdit.Educations)
                {
                    CreateOrUpdateEducation(_context, edu);
                }

                foreach (var cert in toEdit.Certificates)
                {
                    CreateOrUpdateCertificate(_context, cert);
                }

                foreach (var lang in toEdit.Languages)
                {
                    CreateOrUpdateLanguage(_context, lang);
                }

                foreach (var exp in toEdit.ProfessionalExperiences)
                {
                    CreateOrUpdateProfessionalExperience(_context, exp);
                }

                foreach (var refer in toEdit.ProfessionalReferences)
                {
                    CreateOrUpdateProfessionalReference(_context, refer);
                }

                _context.SaveChanges();
            }
        }

        private void CreateOrUpdateMobility(KlanikContext context, MobilityKonsultant item)
        {
            var exist = context.Mobilites.Any(x => x.KonsultantId == item.KonsultantId && x.BusinessUnitId == item.BusinessUnitId);
            context.Entry(item).State = exist ? EntityState.Modified : EntityState.Added;
            //context.Add(item);
        }

        private static void CreateOrUpdateProfessionalReference(KlanikContext _context, ProfessionalReference refer)
        {
            var referExists = _context.ProfessionalReferences.Any(x => x.Id == refer.Id);

            _context.Entry(refer).State =
                referExists ?
                EntityState.Modified :
                EntityState.Added;

            if (!referExists)
            {
                var contact = new Contact
                {
                    Mail = refer.Contacts.Mail,
                    Phone = refer.Contacts.Phone,
                    ProfessionalReference = refer
                };

                _context.Entry(contact).State = EntityState.Added;
            }
        }

        private static void CreateOrUpdateProfessionalExperience(KlanikContext _context, ProfessionalExperience exp)
        {
            var profExpExists = _context.ProfessionalExperiences.Any(x => x.Id == exp.Id);

            _context.Entry(exp).State =
                profExpExists ?
                EntityState.Modified :
                EntityState.Added;
        }

        private static void CreateOrUpdateLanguage(KlanikContext _context, KnownLanguage lang)
        {
            var knownLangExists = _context.KnownLanguages.Any(x => x.LanguageId == lang.LanguageId
                                      && x.KonsultantId == lang.KonsultantId);

            var langExists = _context.Languages.Any(x => x.Id == lang.Language.Id);

            _context.Entry(lang).State =
                knownLangExists ?
                    EntityState.Modified :
                    EntityState.Added;

            _context.Entry(lang.Language).State =
                langExists ?
                EntityState.Modified :
                EntityState.Added;
        }

        private static void CreateOrUpdateCertificate(KlanikContext _context, OwnedCertificate cert)
        {
            var ownedCertExists = _context.OwnedCertificates.Any(x => x.CertificateId == cert.CertificateId
                && x.KonsultantId == cert.KonsultantId);

            var certExists = _context.Certificates.Any(x => x.Id == cert.Certificate.Id);

            _context.Entry(cert).State =
                ownedCertExists ?
                EntityState.Modified :
                EntityState.Added;

            _context.Entry(cert.Certificate).State =
                certExists ?
                EntityState.Modified :
                EntityState.Added;
        }

        private static void CreateOrUpdateEducation(KlanikContext _context, PersonalEducation edu)
        {
            var perEduExists = _context.PersonalEducations.Any(x => x.EducationId == edu.EducationId
                                  && x.KonsultantId == edu.KonsultantId);

            var eduExists = _context.Educations.Any(x => x.Id == edu.Education.Id);

            _context.Entry(edu).State =
                perEduExists ?
                EntityState.Modified :
                EntityState.Added;

            _context.Entry(edu.Education).State =
                eduExists ?
                EntityState.Modified :
                EntityState.Added;
        }

        private static void CreateOrUpdateCompetence(KlanikContext _context, OwnedCompetences comp)
        {
            var ownedCompExists = _context.OwnedCompetences.Any(x => x.CompetenceId == comp.CompetenceId
                                    && x.KonsultantId == comp.KonsultantId);
            var compExists = _context.Competences.Any(x => x.Id == comp.CompetenceId);

            _context.Entry(comp).State =
                ownedCompExists ?
                EntityState.Modified :
                EntityState.Added;

            _context.Entry(comp.Competence).State =
                compExists ?
                EntityState.Modified :
                EntityState.Added;
        }




    }
}
