using Klanik_Internal.Models;
using Klanik_Internal.Models.ViewModels;
using Klanik_Internal.Services;
using System;
using System.Linq;

namespace Klanik_Internal.Tools {
    public class Mapper : IMapper {
        private readonly IService<Competence> _skillService;
        private readonly IService<Language> _langService;
        private readonly IService<Certificate> _certifService;
        private readonly IService<Education> _eduService;
        private readonly IService<TechnicalEnvironment> _techService;
        private readonly IService<ProfessionalExperience> _expService;
        private readonly IService<Accomplishment> _accomplishmentService;
        private readonly IService<BusinessUnit> _busServices;
        public readonly IService<Konsultant> _konsultantService;

        public Mapper(IService<Competence> skillService,
                        IService<Language> langService,
                        IService<Certificate> certifService,
                        IService<TechnicalEnvironment> techService,
                        IService<Education> eduService,
                        IService<ProfessionalExperience> expService,
                        IService<Konsultant> konsultantService,
                        IService<Accomplishment> accomplishmentService,
                        IService<BusinessUnit> busService)
        {
            _skillService = skillService;
            _langService = langService;
            _certifService = certifService;
            _techService = techService;
            _eduService = eduService;
            _expService = expService;
            _konsultantService = konsultantService;
            _accomplishmentService = accomplishmentService;
            _busServices = busService;
        }

        public Konsultant toKonsultant(KonsultantCreationModel toCreate)
        {
            Konsultant newConsultant = new Konsultant
            {
                Id = Guid.Parse(toCreate.Id),
                Name = toCreate.Name,
                Surname = toCreate.Surname,
                Availability = toCreate.Availability,
                Function = toCreate.Function
            };

            foreach (var comp in toCreate.Competences)
            {
                SetCompetence(newConsultant, comp);
            }
            foreach (var lang in toCreate.Languages)
            {
                SetLanguage(newConsultant, lang);
            }
            foreach (var Mob in toCreate.Mobilites)
            {
                SetMobilities(newConsultant, Mob);
            }
            foreach (var edu in toCreate.Educations)
            {
                SetEducation(newConsultant, edu);
            }

            foreach (var certif in toCreate.Certificates)
            {
                SetCertificate(newConsultant, certif);
            }

            foreach (var exper in toCreate.ProfessionalExperiences)
            {
                SetProfessionalExperience(newConsultant, exper);
            }

            foreach (var refer in toCreate.ProfessionalReferences)
            {
                SetProfessionalReference(newConsultant, refer);
            }

            return newConsultant;
        }

        private void SetMobilities(Konsultant newConsultant, MobilityKonsultantVm mob)
        {
            var bu = _busServices.GetById((mob.id));
            MobilityKonsultant mobility = new MobilityKonsultant { BU = bu, BusinessUnitId = bu.Id, KonsultantId = newConsultant.Id };
            newConsultant.Mobilites.Add(mobility);
        }

        public KonsultantCreationModel toViewModel(Konsultant source)
        {
            if (source == null)
                return new KonsultantCreationModel();

            var result = new KonsultantCreationModel
            {
                Id = source.Id.ToString(),
                Name = source.Name,
                Surname = source.Surname,
                Function = source.Function,
                Availability = source.Availability.Date,
            };

            foreach (var comp in source.Competences)
            {
                var current = new CompetenceViewModel
                {
                    Id = comp.CompetenceId.ToString(),
                    Name = comp.Competence?.Name,
                    Rating = (int)comp.Rating,
                    IsRelevant = comp.IsRelevant
                };

                result.Competences.Add(current);

                result.Competences = result.Competences.OrderByDescending(x => x.Rating).ToList();
            }

            foreach (var lang in source.Languages)
            {
                var current = new LanguageViewModel
                {
                    Id = lang.LanguageId.ToString(),
                    Name = lang.Language?.Name,
                    Fluency = (int)lang.Fluency,
                    IsRelevant = lang.IsRelevant,
                };

                result.Languages.Add(current);
            }

            foreach (var edu in source.Educations)
            {
                var current = new EducationViewModel
                {
                    Id = edu.EducationId.ToString(),
                    Name = edu.Education?.Name,
                    StartDate = edu.StartDate.Date,
                    EndDate = edu.EndDate.Date,
                    IsRelevant = edu.IsRelevant
                };

                result.Educations.Add(current);
            }

            foreach (var cert in source.Certificates)
            {
                var current = new CertificateViewModel
                {
                    Id = cert.CertificateId.ToString(),
                    Name = cert.Certificate?.Name,
                    Obtension = cert.Obtension,
                    EndOfValidity = cert.EndOfValidity,
                    IsRelevant = cert.IsRelevant
                };

                result.Certificates.Add(current);
            }

            foreach (var exp in source.ProfessionalExperiences)
            {
                var curr = new ProfessionalExperienceViewModel
                {
                    Id = exp.Id.ToString(),
                    Position = exp.Position,
                    Summary = exp.Summary,
                    Customer = exp.Customer,
                    StartDate = exp.StartDate.Date,
                    EndDate = exp.EndDate.Date,
                    IsRelevant = exp.IsRelevant
                };

                foreach (var acc in exp.Accomplishments)
                {
                    var accomplished = new AccomplishmentViewModel
                    {
                        Id = acc.Id.ToString(),
                        Title = acc.Title,
                        IsRelevant = acc.IsRelevant
                    };
                    curr.Accomplishments.Add(accomplished);
                };

                foreach (var tech in exp.TechnicalEnvironments)
                {
                    var technical = new TechnicalEnvironmentViewModel
                    {
                        Id = tech.Id.ToString(),
                        Name = tech.Name,
                        IsRelevant = tech.IsRelevant
                    };

                    curr.TechnicalEnvironments.Add(technical);
                };

                result.ProfessionalExperiences.Add(curr);

            }

            foreach (var refer in source.ProfessionalReferences)
            {
                var current = new ProfessionalReferenceViewModel
                {
                    Id = refer.Id.ToString(),
                    Name = refer.Name,
                    Surname = refer.Surname,
                    Function = refer.Function,
                    Mail = refer.Contacts?.Mail,
                    Phone = refer.Contacts?.Phone
                };

                result.ProfessionalReferences.Add(current);
            }
            foreach (var mob in source.Mobilites)
            {
                var current = new MobilityKonsultantVm { name = $"{mob.BU.Name}", id = mob.BusinessUnitId };
                result.Mobilites.Add(current);
            }
            return result;
        }

        public Konsultant ToPdfModel(Konsultant source)
        {
            var result = new Konsultant
            {
                Id = source.Id,
                Availability = source.Availability,
                Name = source.Name,
                Surname = source.Surname,
                Function = source.Function,
                Certificates = source.Certificates.Where(c => c.IsRelevant).ToList(),
                Educations = source.Educations.Where(e => e.IsRelevant).ToList(),
                Competences = source.Competences.Where(c => c.IsRelevant).ToList(),
                Languages = source.Languages.Where(l => l.IsRelevant).ToList(),
                ProfessionalExperiences = source.ProfessionalExperiences.Where(p => p.IsRelevant).ToList(),
                ProfessionalReferences = source.ProfessionalReferences
            };

            return result;
        }


        #region internals
        private void SetProfessionalReference(Konsultant newConsultant, ProfessionalReferenceViewModel refer)
        {
            ProfessionalReference current;

            if (string.IsNullOrEmpty(refer.Id))
            {
                current = new ProfessionalReference
                {
                    Name = refer.Name,
                    Surname = refer.Surname,
                    Function = refer.Function,
                    KonsultantId = newConsultant.Id,
                    Company = refer.Company
                };

                var Contacts = new Contact
                {
                    Mail = refer.Mail,
                    Phone = refer.Phone,
                    ProfessionalReferenceId = current.Id,
                };

                current.Contacts = Contacts;
                newConsultant.ProfessionalReferences.Add(current);
            }
        }

        private void SetProfessionalExperience(Konsultant newConsultant, ProfessionalExperienceViewModel exper)
        {
            ProfessionalExperience current = null;
            if (!string.IsNullOrEmpty(exper.Id))
            {
                //update values if exists
                current = _expService.GetById(Guid.Parse(exper.Id));
                current.IsRelevant = exper.IsRelevant;
                current.Position = exper.Position;
                current.StartDate = exper.StartDate;
                current.EndDate = exper.EndDate;
                current.Summary = exper.Summary;
            }
            else
            {
                //create a new one
                current = new ProfessionalExperience(exper, newConsultant.Id);
            }

            foreach (var acc in exper.Accomplishments)
            {
                SetAccomplishment(current, acc);
            }

            foreach (var tech in exper.TechnicalEnvironments)
            {
                SetTechnicalEnvironment(current, tech);
            }

            newConsultant.ProfessionalExperiences.Add(current);
        }

        private void SetTechnicalEnvironment(ProfessionalExperience current, TechnicalEnvironmentViewModel tech)
        {
            var existing = string.IsNullOrEmpty(tech.Id) ?
                new TechnicalEnvironment
                {
                    IsRelevant = tech.IsRelevant,
                    Name = tech.Name,
                } :
                _techService.GetById(Guid.Parse(tech.Id));

            if (tech.IsDeleted)
            {
                _techService.Delete(existing);
            }
            else
            {

                existing.IsRelevant = tech.IsRelevant;
                existing.Name = tech.Name;

                if (string.IsNullOrEmpty(tech.Id))
                {
                    current.TechnicalEnvironments.Add(existing);
                }
            }
        }

        private void SetAccomplishment(ProfessionalExperience current, AccomplishmentViewModel acc)
        {
            Accomplishment existing = string.IsNullOrEmpty(acc.Id) ?
                new Accomplishment
                {
                    IsRelevant = acc.IsRelevant,
                    Summary = "",
                    Title = acc.Title,
                } :
                _accomplishmentService.GetById(Guid.Parse(acc.Id));

            if (acc.IsDeleted)
            {
                _accomplishmentService.Delete(existing);
            }
            else
            {

                existing.IsRelevant = acc.IsRelevant;
                existing.Title = acc.Title;

                if (string.IsNullOrEmpty(acc.Id))
                {
                    current.Accomplishments.Add(existing);
                }
            }
        }

        private void SetCertificate(Konsultant newConsultant, CertificateViewModel certif)
        {

            Certificate current = string.IsNullOrEmpty(certif.Id) ?
                new Certificate
                {
                    Name = certif.Name
                } :
                _certifService.GetById(Guid.Parse(certif.Id));

            if (certif.IsDeleted)
            {
                _certifService.Delete(current);
            }
            else
            {
                newConsultant.Certificates.Add(
                    new OwnedCertificate
                    {
                        Certificate = current,
                        CertificateId = current.Id,
                        KonsultantId = newConsultant.Id,
                        Obtension = certif.Obtension,
                        EndOfValidity = certif.EndOfValidity,
                        IsRelevant = certif.IsRelevant
                        //Obtension = DateTime.ParseExact(certif.Obtension, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        //EndOfValidity = DateTime.ParseExact(certif.EndOfValidity, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    });
            }
        }

        private void SetEducation(Konsultant newConsultant, EducationViewModel edu)
        {


            Education current = string.IsNullOrEmpty(edu.Id) ?
                new Education
                {
                    Name = edu.Name
                } :
            _eduService.GetById(Guid.Parse(edu.Id));

            if (edu.IsDeleted)
            {
                _eduService.Delete(current);
            }
            else
            {
                newConsultant.Educations.Add(
                        new PersonalEducation
                        {
                            Education = current,
                            EducationId = current.Id,
                            KonsultantId = newConsultant.Id,
                            StartDate = edu.StartDate,
                            EndDate = edu.EndDate,
                            IsRelevant = edu.IsRelevant
                            //StartDate = DateTime.ParseExact(edu.StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            //EndDate = DateTime.ParseExact(edu.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        });
            }
        }

        private void SetLanguage(Konsultant newConsultant, LanguageViewModel lang)
        {

            Language current = string.IsNullOrEmpty(lang.Id) ?
                new Language
                {
                    Name = lang.Name
                } :
                _langService.GetById(Guid.Parse(lang.Id));

            if (lang.IsDeleted)
            {
                _langService.Delete(current);
            }
            else
            {
                newConsultant.Languages.Add(
                    new KnownLanguage
                    {
                        Language = current,
                        LanguageId = current.Id,
                        KonsultantId = newConsultant.Id,
                        IsRelevant = lang.IsRelevant,
                        Fluency = (Fluency)Enum.Parse(typeof(Fluency), lang.Fluency.ToString())
                    });
            }
        }

        private void SetCompetence(Konsultant newConsultant, CompetenceViewModel comp)
        {

            Competence current = string.IsNullOrEmpty(comp.Id) ?
                new Competence
                {
                    Name = comp.Name
                } :
                _skillService.GetById(Guid.Parse(comp.Id));

            if (comp.IsDeleted)
            {
                _skillService.Delete(current);
            }
            else
            {
                newConsultant.Competences.Add(
                    new OwnedCompetences
                    {
                        Competence = current,
                        KonsultantId = newConsultant.Id,
                        CompetenceId = current.Id,
                        IsRelevant = comp.IsRelevant,
                        Rating = (Rating)Enum.Parse(typeof(Rating), comp.Rating.ToString())
                    });
            }
        }
        #endregion

    }

    public interface IMapper {
        Konsultant toKonsultant(KonsultantCreationModel toCreate);

        KonsultantCreationModel toViewModel(Konsultant source);

        Konsultant ToPdfModel(Konsultant source);
    }
}
