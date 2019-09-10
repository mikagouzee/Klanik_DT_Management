using Microsoft.EntityFrameworkCore;
using System;

namespace Klanik_Internal.Models {
    public class KlanikContext : DbContext {
        public KlanikContext(DbContextOptions<KlanikContext> options) : base(options)
        {

        }

        public DbSet<Konsultant> Konsultants { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<ProfessionalExperience> ProfessionalExperiences { get; set; }
        public DbSet<Accomplishment> Accomplishments { get; set; }
        public DbSet<TechnicalEnvironment> TechnicalEnvironments { get; set; }
        public DbSet<ProfessionalReference> ProfessionalReferences { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<Contry> Countries { get; set; }
        public DbSet<BusinessUnit> businessUnits { get; set; }
        public DbSet<MobilityKonsultant> Mobilites { get; set; }
        public DbSet<OwnedCompetences> OwnedCompetences { get; set; }
        public DbSet<PersonalEducation> PersonalEducations { get; set; }
        public DbSet<OwnedCertificate> OwnedCertificates { get; set; }
        public DbSet<KnownLanguage> KnownLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tablemapping
            modelBuilder.Entity<Konsultant>().ToTable("Konsultant");
            modelBuilder.Entity<Competence>().ToTable("Competence");
            modelBuilder.Entity<Education>().ToTable("Education");
            modelBuilder.Entity<Certificate>().ToTable("Certificate");
            modelBuilder.Entity<ProfessionalExperience>().ToTable("ProfessionalExperience");
            modelBuilder.Entity<Accomplishment>().ToTable("Accomplishment");
            modelBuilder.Entity<TechnicalEnvironment>().ToTable("TechnicalEnvironment");
            modelBuilder.Entity<ProfessionalReference>().ToTable("ProfessionalReference");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Language>().ToTable("Language");
            modelBuilder.Entity<Recruiter>().ToTable("Recruiter");

            modelBuilder.Entity<OwnedCompetences>().ToTable("OwnedCompetence");
            modelBuilder.Entity<PersonalEducation>().ToTable("PersonalEducation");
            modelBuilder.Entity<OwnedCertificate>().ToTable("Owned Certificate");
            modelBuilder.Entity<KnownLanguage>().ToTable("KnownLanguage");

            #endregion

            modelBuilder.Entity<KnownLanguage>().HasKey(
                    l => new { l.KonsultantId, l.LanguageId }
                );


            modelBuilder.Entity<OwnedCertificate>().HasKey(
                    c => new { c.CertificateId, c.KonsultantId }
                );
            modelBuilder.Entity<MobilityKonsultant>().HasKey(
                m => new { m.KonsultantId, m.BusinessUnitId }
                );
            modelBuilder.Entity<MobilityKonsultant>().HasIndex(idx => new { idx.KonsultantId, idx.BusinessUnitId }).IsUnique(true);
            modelBuilder.Entity<PersonalEducation>().HasKey(
                    p => new { p.EducationId, p.KonsultantId }
                );

            modelBuilder.Entity<OwnedCompetences>().HasKey(
                    o => new { o.CompetenceId, o.KonsultantId }
                );

            #region initiate model
            var me = new Konsultant
            {
                Name = "Michel",
                Surname = "Gouzee",
                Id = Guid.NewGuid(),
                Function = "FullStack .Net Developer",
                Availability = DateTime.Now
            };
            var barnab = new Konsultant
            {
                Name = "Barnabé",
                Surname = "Magos",
                Id = Guid.NewGuid(),
                Function = "FullStack .Net Developer",
                Availability = new DateTime(2020, 1, 1)
            };

            var meRecruiter = new Recruiter
            {
                Id = Guid.Parse("d2004e8d-aa24-4c04-a2ed-4e4a475a1cc8"),
                Name = me.Name,
                Surname = me.Surname
            };

            modelBuilder.Entity<Recruiter>().HasData(
                meRecruiter
                );

            modelBuilder.Entity<Konsultant>().HasData(
                me,
                barnab);

            var dotnet = new Competence
            {
                Name = "dotNet"
            };
            var jscript = new Competence
            {
                Name = "javascript",
            };

            modelBuilder.Entity<Competence>().HasData(dotnet, jscript);

            modelBuilder.Entity<OwnedCompetences>().HasData(
                new OwnedCompetences
                {
                    CompetenceId = dotnet.Id,
                    KonsultantId = me.Id,
                    Rating = Rating.VeryGood
                },
                new OwnedCompetences
                {
                    CompetenceId = jscript.Id,
                    KonsultantId = me.Id,
                    Rating = Rating.NeedSupport
                },
                new OwnedCompetences
                {
                    CompetenceId = dotnet.Id,
                    KonsultantId = barnab.Id,
                    Rating = Rating.VeryGood
                },
                new OwnedCompetences
                {
                    CompetenceId = jscript.Id,
                    KonsultantId = barnab.Id,
                    Rating = Rating.VeryGood
                }
                );

            var autodi = new Education
            {
                Name = "SelfTaught",
            };
            var school = new Education
            {
                Name = "High School"
            };

            modelBuilder.Entity<Education>().HasData(autodi, school);

            var personnalEducations = new PersonalEducation[]
          {
                new PersonalEducation
                {
                    EducationId = autodi.Id,
                    KonsultantId = me.Id,
                    StartDate = new DateTime(2016,10,01),
                    EndDate = new DateTime(2099,12,31)
                },
                new PersonalEducation
                {
                    EducationId = school.Id,
                    KonsultantId = barnab.Id,
                    StartDate = new DateTime(2011, 09, 15),
                    EndDate = new DateTime(2014, 06, 30)
                }
          };

            modelBuilder.Entity<PersonalEducation>().HasData(personnalEducations[0], personnalEducations[1]);

            var fr = new Language
            {
                Name = "Français"
            };
            var neerl = new Language
            {
                Name = "Néerlandais"
            };
            var engl = new Language
            {
                Name = "Anglais"
            };

            modelBuilder.Entity<Language>().HasData(fr, neerl, engl);

            var knownlangMichel1 = new KnownLanguage
            {
                KonsultantId = me.Id,
                LanguageId = fr.Id,
                Fluency = Fluency.Bilingual
            };
            var knownlangMichel2 = new KnownLanguage
            {
                KonsultantId = me.Id,
                LanguageId = neerl.Id,
                Fluency = Fluency.Scholar
            };
            var knownlangMichel3 = new KnownLanguage
            {
                KonsultantId = me.Id,
                LanguageId = engl.Id,
                Fluency = Fluency.Fluent
            };
            var knownLangBar1 = new KnownLanguage
            {
                KonsultantId = barnab.Id,
                LanguageId = fr.Id,
                Fluency = Fluency.Bilingual
            };
            var knownLangBar2 = new KnownLanguage
            {
                KonsultantId = barnab.Id,
                LanguageId = engl.Id,
                Fluency = Fluency.Fluent
            };
            var knownLangBar3 = new KnownLanguage
            {
                KonsultantId = barnab.Id,
                LanguageId = neerl.Id,
                Fluency = Fluency.Beginner
            };

            modelBuilder.Entity<KnownLanguage>().HasData(
                knownlangMichel1,
                knownlangMichel2,
                knownlangMichel3,
                knownLangBar1,
                knownLangBar2,
                knownLangBar3
                );

            var certCsharp = new Certificate
            {
                Name = "C# certified developer"
            };
            var diploma = new Certificate
            {
                Name = "High School Diploma"
            };
            var commonOne = new Certificate
            {
                Name = "BadAss Dev"
            };

            modelBuilder.Entity<Certificate>().HasData(
                certCsharp, diploma, commonOne);

            var ownedCert = new OwnedCertificate
            {
                KonsultantId = me.Id,
                CertificateId = certCsharp.Id,
                Obtension = new DateTime(2017, 09, 28),
                EndOfValidity = new DateTime(2019, 06, 30)
            };
            var ownedCert2 = new OwnedCertificate
            {
                KonsultantId = me.Id,
                CertificateId = commonOne.Id,
                Obtension = new DateTime(2017, 01, 01),
                EndOfValidity = new DateTime(2099, 12, 31)
            };
            var ownedCert3 = new OwnedCertificate
            {
                KonsultantId = barnab.Id,
                CertificateId = diploma.Id,
                Obtension = new DateTime(2014, 06, 30),
                EndOfValidity = new DateTime(2099, 12, 31)
            };
            var ownedCert4 = new OwnedCertificate
            {
                KonsultantId = barnab.Id,
                CertificateId = commonOne.Id,
                Obtension = new DateTime(2014, 01, 01),
                EndOfValidity = new DateTime(2099, 12, 31)
            };


            modelBuilder.Entity<OwnedCertificate>().HasData(
                ownedCert,
                ownedCert2,
                ownedCert3,
                ownedCert4
                );

            #endregion

        }

    }
}
