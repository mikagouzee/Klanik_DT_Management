using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WordProcessor
{
    public partial class KonsultantDbContext : DbContext
    {
        public KonsultantDbContext()
        {
        }

        public KonsultantDbContext(DbContextOptions<KonsultantDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accomplishment> Accomplishment { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<Competence> Competence { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<KnownLanguage> KnownLanguage { get; set; }
        public virtual DbSet<Konsultant> Konsultant { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<OwnedCertificate> OwnedCertificate { get; set; }
        public virtual DbSet<OwnedCompetence> OwnedCompetence { get; set; }
        public virtual DbSet<PersonalEducation> PersonalEducation { get; set; }
        public virtual DbSet<ProfessionalExperience> ProfessionalExperience { get; set; }
        public virtual DbSet<ProfessionalReference> ProfessionalReference { get; set; }
        public virtual DbSet<Recruiter> Recruiter { get; set; }
        public virtual DbSet<TechnicalEnvironment> TechnicalEnvironment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-60VS50FB\\SQLEXPRESS;Initial Catalog=KonsultantDb;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Accomplishment>(entity =>
            {
                entity.HasIndex(e => e.ProfessionalExperienceId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ProfessionalExperience)
                    .WithMany(p => p.Accomplishment)
                    .HasForeignKey(d => d.ProfessionalExperienceId);
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.ProfessionalReferenceId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ProfessionalReference)
                    .WithOne(p => p.Contact)
                    .HasForeignKey<Contact>(d => d.ProfessionalReferenceId);
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<KnownLanguage>(entity =>
            {
                entity.HasKey(e => new { e.KonsultantId, e.LanguageId });

                entity.HasIndex(e => e.LanguageId);

                entity.HasOne(d => d.Konsultant)
                    .WithMany(p => p.KnownLanguage)
                    .HasForeignKey(d => d.KonsultantId);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.KnownLanguage)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<Konsultant>(entity =>
            {
                entity.HasIndex(e => e.RecruiterId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Recruiter)
                    .WithMany(p => p.Konsultant)
                    .HasForeignKey(d => d.RecruiterId);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<OwnedCertificate>(entity =>
            {
                entity.HasKey(e => new { e.CertificateId, e.KonsultantId });

                entity.ToTable("Owned Certificate");

                entity.HasIndex(e => e.KonsultantId);

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.OwnedCertificate)
                    .HasForeignKey(d => d.CertificateId);

                entity.HasOne(d => d.Konsultant)
                    .WithMany(p => p.OwnedCertificate)
                    .HasForeignKey(d => d.KonsultantId);
            });

            modelBuilder.Entity<OwnedCompetence>(entity =>
            {
                entity.HasKey(e => new { e.CompetenceId, e.KonsultantId });

                entity.HasIndex(e => e.KonsultantId);

                entity.HasOne(d => d.Competence)
                    .WithMany(p => p.OwnedCompetence)
                    .HasForeignKey(d => d.CompetenceId);

                entity.HasOne(d => d.Konsultant)
                    .WithMany(p => p.OwnedCompetence)
                    .HasForeignKey(d => d.KonsultantId);
            });

            modelBuilder.Entity<PersonalEducation>(entity =>
            {
                entity.HasKey(e => new { e.EducationId, e.KonsultantId });

                entity.HasIndex(e => e.KonsultantId);

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.PersonalEducation)
                    .HasForeignKey(d => d.EducationId);

                entity.HasOne(d => d.Konsultant)
                    .WithMany(p => p.PersonalEducation)
                    .HasForeignKey(d => d.KonsultantId);
            });

            modelBuilder.Entity<ProfessionalExperience>(entity =>
            {
                entity.HasIndex(e => e.KonsultantId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Konsultant)
                    .WithMany(p => p.ProfessionalExperience)
                    .HasForeignKey(d => d.KonsultantId);
            });

            modelBuilder.Entity<ProfessionalReference>(entity =>
            {
                entity.HasIndex(e => e.KonsultantId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Konsultant)
                    .WithMany(p => p.ProfessionalReference)
                    .HasForeignKey(d => d.KonsultantId);
            });

            modelBuilder.Entity<Recruiter>(entity =>
            {
                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Recruiter)
                    .HasForeignKey(d => d.ContactId);
            });

            modelBuilder.Entity<TechnicalEnvironment>(entity =>
            {
                entity.HasIndex(e => e.ProfessionalExperienceId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ProfessionalExperience)
                    .WithMany(p => p.TechnicalEnvironment)
                    .HasForeignKey(d => d.ProfessionalExperienceId);
            });
        }
    }
}
