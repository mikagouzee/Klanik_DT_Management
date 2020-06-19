﻿// <auto-generated />
using System;
using Klanik_Internal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Klanik_Internal.Migrations
{
    [DbContext(typeof(KlanikContext))]
    [Migration("20190812083152_BU")]
    partial class BU
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Klanik_Internal.Models.Accomplishment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsRelevant");

                    b.Property<Guid>("ProfessionalExperienceId");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalExperienceId");

                    b.ToTable("Accomplishment");
                });

            modelBuilder.Entity("Klanik_Internal.Models.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Certificate");

                    b.HasData(
                        new
                        {
                            Id = new Guid("62dc7fb4-93e1-405c-9180-af140e2483de"),
                            Name = "C# certified developer"
                        },
                        new
                        {
                            Id = new Guid("88d5b4bb-022e-4204-97ab-02d16e94a1f9"),
                            Name = "High School Diploma"
                        },
                        new
                        {
                            Id = new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"),
                            Name = "BadAss Dev"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.Competence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Competence");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"),
                            Name = "dotNet"
                        },
                        new
                        {
                            Id = new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"),
                            Name = "javascript"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Mail");

                    b.Property<string>("Phone");

                    b.Property<Guid>("ProfessionalReferenceId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalReferenceId")
                        .IsUnique();

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Klanik_Internal.Models.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Education");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51757372-be54-4fe3-9d00-16a8eb8f67b9"),
                            Name = "SelfTaught"
                        },
                        new
                        {
                            Id = new Guid("ea527782-e31e-49ac-b2a6-3b6fa617569d"),
                            Name = "High School"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.KnownLanguage", b =>
                {
                    b.Property<Guid>("KonsultantId");

                    b.Property<Guid>("LanguageId");

                    b.Property<int>("Fluency");

                    b.Property<bool>("IsRelevant");

                    b.HasKey("KonsultantId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("KnownLanguage");

                    b.HasData(
                        new
                        {
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            LanguageId = new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            LanguageId = new Guid("265eb676-873f-444f-a066-3422cb3cf33f"),
                            Fluency = 2,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            LanguageId = new Guid("3adbd371-472f-4229-b290-f408ade231c8"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            LanguageId = new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            LanguageId = new Guid("3adbd371-472f-4229-b290-f408ade231c8"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            LanguageId = new Guid("265eb676-873f-444f-a066-3422cb3cf33f"),
                            Fluency = 1,
                            IsRelevant = true
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.Konsultant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Availability");

                    b.Property<string>("Function");

                    b.Property<string>("Name");

                    b.Property<Guid?>("RecruiterId");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("RecruiterId");

                    b.ToTable("Konsultant");

                    b.HasData(
                        new
                        {
                            Id = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            Availability = new DateTime(2019, 8, 12, 10, 31, 51, 627, DateTimeKind.Local).AddTicks(4511),
                            Function = "FullStack .Net Developer",
                            Name = "Michel",
                            Surname = "Gouzee"
                        },
                        new
                        {
                            Id = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            Availability = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Function = "FullStack .Net Developer",
                            Name = "Barnabé",
                            Surname = "Magos"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"),
                            Name = "Français"
                        },
                        new
                        {
                            Id = new Guid("265eb676-873f-444f-a066-3422cb3cf33f"),
                            Name = "Néerlandais"
                        },
                        new
                        {
                            Id = new Guid("3adbd371-472f-4229-b290-f408ade231c8"),
                            Name = "Anglais"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.OwnedCertificate", b =>
                {
                    b.Property<Guid>("CertificateId");

                    b.Property<Guid>("KonsultantId");

                    b.Property<DateTime?>("EndOfValidity");

                    b.Property<bool>("IsRelevant");

                    b.Property<DateTime>("Obtension");

                    b.HasKey("CertificateId", "KonsultantId");

                    b.HasIndex("KonsultantId");

                    b.ToTable("Owned Certificate");

                    b.HasData(
                        new
                        {
                            CertificateId = new Guid("62dc7fb4-93e1-405c-9180-af140e2483de"),
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            EndOfValidity = new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"),
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("88d5b4bb-022e-4204-97ab-02d16e94a1f9"),
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"),
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.OwnedCompetences", b =>
                {
                    b.Property<Guid>("CompetenceId");

                    b.Property<Guid>("KonsultantId");

                    b.Property<bool>("IsRelevant");

                    b.Property<int>("Rating");

                    b.HasKey("CompetenceId", "KonsultantId");

                    b.HasIndex("KonsultantId");

                    b.ToTable("OwnedCompetence");

                    b.HasData(
                        new
                        {
                            CompetenceId = new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"),
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"),
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            IsRelevant = true,
                            Rating = 2
                        },
                        new
                        {
                            CompetenceId = new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"),
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"),
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            IsRelevant = true,
                            Rating = 4
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.PersonalEducation", b =>
                {
                    b.Property<Guid>("EducationId");

                    b.Property<Guid>("KonsultantId");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsRelevant");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("EducationId", "KonsultantId");

                    b.HasIndex("KonsultantId");

                    b.ToTable("PersonalEducation");

                    b.HasData(
                        new
                        {
                            EducationId = new Guid("51757372-be54-4fe3-9d00-16a8eb8f67b9"),
                            KonsultantId = new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"),
                            EndDate = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            StartDate = new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EducationId = new Guid("ea527782-e31e-49ac-b2a6-3b6fa617569d"),
                            KonsultantId = new Guid("52d08ade-6714-403f-bb89-59b3da309649"),
                            EndDate = new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            StartDate = new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.ProfessionalExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Context");

                    b.Property<string>("Customer");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsRelevant");

                    b.Property<Guid>("KonsultantId");

                    b.Property<string>("Position");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.HasIndex("KonsultantId");

                    b.ToTable("ProfessionalExperience");
                });

            modelBuilder.Entity("Klanik_Internal.Models.ProfessionalReference", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<string>("Function");

                    b.Property<Guid>("KonsultantId");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("KonsultantId");

                    b.ToTable("ProfessionalReference");
                });

            modelBuilder.Entity("Klanik_Internal.Models.Recruiter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ContactId");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Recruiter");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2004e8d-aa24-4c04-a2ed-4e4a475a1cc8"),
                            Name = "Michel",
                            Surname = "Gouzee"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.TechnicalEnvironment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsRelevant");

                    b.Property<string>("Name");

                    b.Property<string>("Option");

                    b.Property<Guid>("ProfessionalExperienceId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalExperienceId");

                    b.ToTable("TechnicalEnvironment");
                });

            modelBuilder.Entity("Klanik_Internal.Models.Accomplishment", b =>
                {
                    b.HasOne("Klanik_Internal.Models.ProfessionalExperience")
                        .WithMany("Accomplishments")
                        .HasForeignKey("ProfessionalExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.Contact", b =>
                {
                    b.HasOne("Klanik_Internal.Models.ProfessionalReference", "ProfessionalReference")
                        .WithOne("Contacts")
                        .HasForeignKey("Klanik_Internal.Models.Contact", "ProfessionalReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.KnownLanguage", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Konsultant")
                        .WithMany("Languages")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Klanik_Internal.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.Konsultant", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Recruiter", "Recruiter")
                        .WithMany("Portfolio")
                        .HasForeignKey("RecruiterId");
                });

            modelBuilder.Entity("Klanik_Internal.Models.OwnedCertificate", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Klanik_Internal.Models.Konsultant")
                        .WithMany("Certificates")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.OwnedCompetences", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Competence", "Competence")
                        .WithMany()
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Klanik_Internal.Models.Konsultant")
                        .WithMany("Competences")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.PersonalEducation", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Klanik_Internal.Models.Konsultant")
                        .WithMany("Educations")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.ProfessionalExperience", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Konsultant")
                        .WithMany("ProfessionalExperiences")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.ProfessionalReference", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Konsultant")
                        .WithMany("ProfessionalReferences")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Klanik_Internal.Models.Recruiter", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");
                });

            modelBuilder.Entity("Klanik_Internal.Models.TechnicalEnvironment", b =>
                {
                    b.HasOne("Klanik_Internal.Models.ProfessionalExperience")
                        .WithMany("TechnicalEnvironments")
                        .HasForeignKey("ProfessionalExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}