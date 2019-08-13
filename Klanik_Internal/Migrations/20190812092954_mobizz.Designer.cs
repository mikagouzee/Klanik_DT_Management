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
    [Migration("20190812092954_mobizz")]
    partial class mobizz
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
                            Id = new Guid("b8616c64-09e1-42de-bd62-75646d2a18a1"),
                            Name = "C# certified developer"
                        },
                        new
                        {
                            Id = new Guid("2459d084-fb56-4fbf-b0de-f6ad862300e1"),
                            Name = "High School Diploma"
                        },
                        new
                        {
                            Id = new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"),
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
                            Id = new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"),
                            Name = "dotNet"
                        },
                        new
                        {
                            Id = new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"),
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
                            Id = new Guid("eeffe8d5-0856-4d7a-865a-3e73cf8b88e2"),
                            Name = "SelfTaught"
                        },
                        new
                        {
                            Id = new Guid("0f2fbb4f-3500-40f4-b94b-2ca5fdd99ff9"),
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
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            LanguageId = new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            LanguageId = new Guid("7b32694b-73e3-4185-801c-3433cce3a667"),
                            Fluency = 2,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            LanguageId = new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
                            LanguageId = new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
                            LanguageId = new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
                            LanguageId = new Guid("7b32694b-73e3-4185-801c-3433cce3a667"),
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
                            Id = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            Availability = new DateTime(2019, 8, 12, 11, 29, 54, 104, DateTimeKind.Local).AddTicks(7293),
                            Function = "FullStack .Net Developer",
                            Name = "Michel",
                            Surname = "Gouzee"
                        },
                        new
                        {
                            Id = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
                            Availability = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Function = "FullStack .Net Developer",
                            Name = "Barnabé",
                            Surname = "Magos"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.KonsultantMobility", b =>
                {
                    b.Property<Guid>("KonsultantId");

                    b.Property<Guid>("MobilityId");

                    b.HasKey("KonsultantId", "MobilityId");

                    b.HasIndex("MobilityId");

                    b.ToTable("KonsultantMobility");
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
                            Id = new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"),
                            Name = "Français"
                        },
                        new
                        {
                            Id = new Guid("7b32694b-73e3-4185-801c-3433cce3a667"),
                            Name = "Néerlandais"
                        },
                        new
                        {
                            Id = new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"),
                            Name = "Anglais"
                        });
                });

            modelBuilder.Entity("Klanik_Internal.Models.Mobilitie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessUnit");

                    b.Property<int>("CountriId");

                    b.Property<string>("Country");

                    b.Property<Guid>("MobilityId");

                    b.HasKey("Id");

                    b.ToTable("Mobilites");
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
                            CertificateId = new Guid("b8616c64-09e1-42de-bd62-75646d2a18a1"),
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            EndOfValidity = new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"),
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("2459d084-fb56-4fbf-b0de-f6ad862300e1"),
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"),
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
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
                            CompetenceId = new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"),
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"),
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            IsRelevant = true,
                            Rating = 2
                        },
                        new
                        {
                            CompetenceId = new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"),
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"),
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
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
                            EducationId = new Guid("eeffe8d5-0856-4d7a-865a-3e73cf8b88e2"),
                            KonsultantId = new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"),
                            EndDate = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            StartDate = new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EducationId = new Guid("0f2fbb4f-3500-40f4-b94b-2ca5fdd99ff9"),
                            KonsultantId = new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"),
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

            modelBuilder.Entity("Klanik_Internal.Models.KonsultantMobility", b =>
                {
                    b.HasOne("Klanik_Internal.Models.Konsultant", "konsultant")
                        .WithMany("Mobilities")
                        .HasForeignKey("KonsultantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Klanik_Internal.Models.Mobilitie", "mobility")
                        .WithMany("konsultants")
                        .HasForeignKey("MobilityId")
                        .OnDelete(DeleteBehavior.Cascade);
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
