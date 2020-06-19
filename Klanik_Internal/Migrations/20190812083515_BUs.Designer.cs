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
    [Migration("20190812083515_BUs")]
    partial class BUs
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
                            Id = new Guid("dac6e6cb-40b3-4378-8ba8-edefa8e6c60f"),
                            Name = "C# certified developer"
                        },
                        new
                        {
                            Id = new Guid("8b10a447-c1d2-4042-b346-56f38403f774"),
                            Name = "High School Diploma"
                        },
                        new
                        {
                            Id = new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"),
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
                            Id = new Guid("85eab401-bab0-4236-a587-673b792d0aa2"),
                            Name = "dotNet"
                        },
                        new
                        {
                            Id = new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"),
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
                            Id = new Guid("a5033f9d-a3d9-46ec-96dc-10875830e91a"),
                            Name = "SelfTaught"
                        },
                        new
                        {
                            Id = new Guid("bc26429a-67ca-453b-a209-681b4dc560bd"),
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
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            LanguageId = new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            LanguageId = new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"),
                            Fluency = 2,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            LanguageId = new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
                            LanguageId = new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
                            LanguageId = new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
                            LanguageId = new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"),
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
                            Id = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            Availability = new DateTime(2019, 8, 12, 10, 35, 15, 632, DateTimeKind.Local).AddTicks(7943),
                            Function = "FullStack .Net Developer",
                            Name = "Michel",
                            Surname = "Gouzee"
                        },
                        new
                        {
                            Id = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
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
                            Id = new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"),
                            Name = "Français"
                        },
                        new
                        {
                            Id = new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"),
                            Name = "Néerlandais"
                        },
                        new
                        {
                            Id = new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"),
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
                            CertificateId = new Guid("dac6e6cb-40b3-4378-8ba8-edefa8e6c60f"),
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            EndOfValidity = new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"),
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("8b10a447-c1d2-4042-b346-56f38403f774"),
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"),
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
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
                            CompetenceId = new Guid("85eab401-bab0-4236-a587-673b792d0aa2"),
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"),
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            IsRelevant = true,
                            Rating = 2
                        },
                        new
                        {
                            CompetenceId = new Guid("85eab401-bab0-4236-a587-673b792d0aa2"),
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"),
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
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
                            EducationId = new Guid("a5033f9d-a3d9-46ec-96dc-10875830e91a"),
                            KonsultantId = new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"),
                            EndDate = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            StartDate = new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EducationId = new Guid("bc26429a-67ca-453b-a209-681b4dc560bd"),
                            KonsultantId = new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"),
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