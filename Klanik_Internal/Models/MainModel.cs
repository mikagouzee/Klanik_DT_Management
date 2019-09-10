using Klanik_Internal.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Klanik_Internal.Models {
    public class KlanikEntity {
        [Key]
        public Guid Id { get; set; }

        public KlanikEntity()
        {
            Id = Guid.NewGuid();
        }

        public KlanikEntity(string id)
        {
            Id = Guid.Parse(id);
        }
    }

    public class Recruiter : KlanikEntity {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Contact Contact { get; set; }
        public virtual HashSet<Konsultant> Portfolio { get; set; } = new HashSet<Konsultant>();

    }


    public class Konsultant : KlanikEntity {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Function { get; set; }
        public DateTime Availability { get; set; }

        public virtual List<MobilityKonsultant> Mobilites { get; set; } = new List<MobilityKonsultant>();
        public virtual List<OwnedCompetences> Competences { get; set; } = new List<OwnedCompetences>();
        public virtual List<PersonalEducation> Educations { get; set; } = new List<PersonalEducation>();
        public virtual List<OwnedCertificate> Certificates { get; set; } = new List<OwnedCertificate>();
        public virtual List<KnownLanguage> Languages { get; set; } = new List<KnownLanguage>();
        public virtual List<ProfessionalExperience> ProfessionalExperiences { get; set; } = new List<ProfessionalExperience>();
        public virtual List<ProfessionalReference> ProfessionalReferences { get; set; } = new List<ProfessionalReference>();
        [JsonIgnore]
        public virtual Recruiter Recruiter { get; set; }
    }

    public class Competence : KlanikEntity {
        public string Name { get; set; }

    }

    public class Education : KlanikEntity {
        public string Name { get; set; }

    }

    public class Certificate : KlanikEntity {
        public string Name { get; set; }

    }

    public class ProfessionalExperience : KlanikEntity {
        public Guid KonsultantId { get; set; }
        public string Position { get; set; }
        public string Context { get; set; }
        public string Summary { get; set; }
        public string Customer { get; set; }
        public bool IsRelevant { get; set; } = true;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Accomplishment> Accomplishments { get; set; } = new List<Accomplishment>();
        public virtual List<TechnicalEnvironment> TechnicalEnvironments { get; set; } = new List<TechnicalEnvironment>();

        public ProfessionalExperience()
        {

        }

        public ProfessionalExperience(ProfessionalExperienceViewModel exper, Guid konsultantId)
        {
            Position = exper.Position;
            Summary = exper.Summary;
            Customer = exper.Customer;
            StartDate = exper.StartDate;
            EndDate = exper.EndDate;
            IsRelevant = exper.IsRelevant;
            KonsultantId = konsultantId;
        }
    }

    public class Accomplishment : KlanikEntity {
        public Guid ProfessionalExperienceId { get; set; }

        public bool IsRelevant { get; set; } = true;
        public string Title { get; set; }
        public string Summary { get; set; }

    }

    public class TechnicalEnvironment : KlanikEntity {
        public Guid ProfessionalExperienceId { get; set; }

        public bool IsRelevant { get; set; } = true;
        public string Name { get; set; }
        public string Option { get; set; }
    }

    public class ProfessionalReference : KlanikEntity {
        public Guid KonsultantId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Function { get; set; }
        public string Company { get; set; }
        public virtual Contact Contacts { get; set; }

    }

    public class Contact : KlanikEntity {
        public Guid ProfessionalReferenceId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public virtual ProfessionalReference ProfessionalReference { get; set; }
    }

    public class Language : KlanikEntity {
        public string Name { get; set; }
    }

    public enum Rating {
        Unknown = 0,
        SomeCompetences = 1,
        NeedSupport = 2,
        Good = 3,
        VeryGood = 4,
        Expert = 5
    }

    public enum Fluency {
        Unknown = 0,
        Beginner = 1,
        Scholar = 2,
        Technical = 3,
        Fluent = 4,
        Bilingual = 5
    }

    public class Contry : KlanikEntity {
        public string Name { get; set; }
    }
    //Business
    public class BusinessUnit : KlanikEntity {
        public string Name { get; set; }
        public Contry Contry { get; set; }
    }
    //mapped entities
    public class MobilityKonsultant {
        public Guid KonsultantId { get; set; }
        public Guid BusinessUnitId { get; set; }
        public virtual BusinessUnit BU { get; set; }

    }


    public class OwnedCompetences {
        public Guid CompetenceId { get; set; }
        public Guid KonsultantId { get; set; }
        public Rating Rating { get; set; }
        public bool IsRelevant { get; set; } = true;
        public virtual Competence Competence { get; set; }
    }

    public class PersonalEducation {
        public Guid EducationId { get; set; }
        public Guid KonsultantId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsRelevant { get; set; } = true;

        public virtual Education Education { get; set; }
    }

    public class OwnedCertificate {
        public Guid CertificateId { get; set; }
        public Guid KonsultantId { get; set; }
        public DateTime Obtension { get; set; }
        public DateTime? EndOfValidity { get; set; }
        public bool IsRelevant { get; set; } = true;
        public virtual Certificate Certificate { get; set; }
    }

    public class KnownLanguage {
        public Guid LanguageId { get; set; }
        public Guid KonsultantId { get; set; }
        public Fluency Fluency { get; set; }

        public bool IsRelevant { get; set; } = true;

        public virtual Language Language { get; set; }
    }

}
