using Klanik_Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Klanik_Internal.Repository
{
    public class KonsultantRepository : IRepository<Konsultant>
    {
        private readonly IServiceProvider _provider;
        private readonly IList<Expression<Func<Konsultant, object>>> _modifiers;

        public KonsultantRepository(IServiceProvider provider)
        {
            _provider = provider;
            _modifiers = new List<Expression<Func<Konsultant, object>>>();
        }

        public void Create(Konsultant toCreate)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                var exists = _context.Konsultants.Any(x => x.Id == toCreate.Id);

                if(exists)
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

        public void Delete(Konsultant toRemove)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                _context.Entry(toRemove).State = EntityState.Deleted;
            }
        }

        public IEnumerable<Konsultant> GetAll()
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                return _context.Konsultants
                    .ToList();
            }
        }

        public Konsultant GetById(Guid id)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                return _context.Konsultants
                    .Include(k => k.Languages)
                        .ThenInclude(l => l.Language)
                    .Include(k => k.Competences)
                        .ThenInclude(c => c.Competence)
                    .Include(k => k.Educations)
                        .ThenInclude(e => e.Education)
                    .Include(k => k.Certificates)
                        .ThenInclude(c => c.Certificate)
                    .Include(k => k.ProfessionalExperiences)
                        .ThenInclude(p => p.Accomplishments)
                    .Include(k => k.ProfessionalExperiences)
                        .ThenInclude(p => p.TechnicalEnvironments)
                    .Include(k => k.ProfessionalReferences)
                        .ThenInclude(p => p.Contacts)
                    .FirstOrDefault(x => x.Id == id);
            }
        }    

        public IRepository<Konsultant> Include(Expression<Func<Konsultant, object>> path)
        {
            _modifiers.Add(path);

            return this;
        }

        public void Update(Konsultant toEdit)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                foreach (var comp in toEdit.Competences)
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

                foreach (var edu in toEdit.Educations)
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

                foreach (var cert in toEdit.Certificates)
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

                foreach (var lang in toEdit.Languages)
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

                foreach (var exp in toEdit.ProfessionalExperiences)
                {
                    var profExpExists = _context.ProfessionalExperiences.Any(x => x.Id == exp.Id);

                    _context.Entry(exp).State =
                        profExpExists ?
                        EntityState.Modified :
                        EntityState.Added;
                }

                foreach (var refer in toEdit.ProfessionalReferences)
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


                _context.SaveChanges();
            }
        }


        //public Konsultant GetByName(string name)
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
        //            .Include(k => k.ProfessionalReferences)
        //            .FirstOrDefault(x => x.Name == name);
        //    }
        //}
    }
}
