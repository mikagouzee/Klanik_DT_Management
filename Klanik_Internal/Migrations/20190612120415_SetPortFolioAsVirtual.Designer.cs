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
    [Migration("20190612120415_SetPortFolioAsVirtual")]
    partial class SetPortFolioAsVirtual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
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
                            Id = new Guid("8ee72fed-7353-4f8f-9268-444a20bf557c"),
                            Name = "C# certified developer"
                        },
                        new
                        {
                            Id = new Guid("044dfa0b-a500-4789-9ba9-ec7080fa5bd6"),
                            Name = "High School Diploma"
                        },
                        new
                        {
                            Id = new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"),
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
                            Id = new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"),
                            Name = "dotNet"
                        },
                        new
                        {
                            Id = new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"),
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
                            Id = new Guid("a76ace17-25ce-4886-9f2f-9bb378c690cb"),
                            Name = "SelfTaught"
                        },
                        new
                        {
                            Id = new Guid("3496c212-d906-4052-a99d-d8cb0d0383ad"),
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
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            LanguageId = new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            LanguageId = new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"),
                            Fluency = 2,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            LanguageId = new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
                            LanguageId = new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
                            LanguageId = new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
                            LanguageId = new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"),
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
                            Id = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            Availability = new DateTime(2019, 6, 12, 14, 4, 15, 268, DateTimeKind.Local).AddTicks(568),
                            Function = "FullStack .Net Developer",
                            Name = "Michel",
                            Surname = "Gouzee"
                        },
                        new
                        {
                            Id = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
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
                            Id = new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"),
                            Name = "Français"
                        },
                        new
                        {
                            Id = new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"),
                            Name = "Néerlandais"
                        },
                        new
                        {
                            Id = new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"),
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
                            CertificateId = new Guid("8ee72fed-7353-4f8f-9268-444a20bf557c"),
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            EndOfValidity = new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"),
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("044dfa0b-a500-4789-9ba9-ec7080fa5bd6"),
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"),
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
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
                            CompetenceId = new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"),
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"),
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            IsRelevant = true,
                            Rating = 2
                        },
                        new
                        {
                            CompetenceId = new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"),
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"),
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
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
                            EducationId = new Guid("a76ace17-25ce-4886-9f2f-9bb378c690cb"),
                            KonsultantId = new Guid("3974a038-d319-4e3b-8e24-140d2646e497"),
                            EndDate = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            StartDate = new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EducationId = new Guid("3496c212-d906-4052-a99d-d8cb0d0383ad"),
                            KonsultantId = new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"),
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
                        .WithMany("Konsultants")
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
