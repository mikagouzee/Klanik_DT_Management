﻿// <auto-generated />
using System;
using Klanik_Internal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Klanik_Internal.Migrations
{
    [DbContext(typeof(KlanikContext))]
    partial class KlanikContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"),
                            Name = "C# certified developer"
                        },
                        new
                        {
                            Id = new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"),
                            Name = "High School Diploma"
                        },
                        new
                        {
                            Id = new Guid("76ff0398-028c-438c-8ad1-9584f0972522"),
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
                            Id = new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"),
                            Name = "dotNet"
                        },
                        new
                        {
                            Id = new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"),
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
                            Id = new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"),
                            Name = "SelfTaught"
                        },
                        new
                        {
                            Id = new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"),
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
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            LanguageId = new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            LanguageId = new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"),
                            Fluency = 2,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            LanguageId = new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
                            LanguageId = new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"),
                            Fluency = 5,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
                            LanguageId = new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"),
                            Fluency = 4,
                            IsRelevant = true
                        },
                        new
                        {
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
                            LanguageId = new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"),
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

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Konsultant");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            Availability = new DateTime(2019, 6, 11, 15, 8, 30, 555, DateTimeKind.Local).AddTicks(2842),
                            Function = "FullStack .Net Developer",
                            Name = "Michel",
                            Surname = "Gouzee"
                        },
                        new
                        {
                            Id = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
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
                            Id = new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"),
                            Name = "Français"
                        },
                        new
                        {
                            Id = new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"),
                            Name = "Néerlandais"
                        },
                        new
                        {
                            Id = new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"),
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
                            CertificateId = new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"),
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            EndOfValidity = new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("76ff0398-028c-438c-8ad1-9584f0972522"),
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"),
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
                            EndOfValidity = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            Obtension = new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CertificateId = new Guid("76ff0398-028c-438c-8ad1-9584f0972522"),
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
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
                            CompetenceId = new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"),
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"),
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            IsRelevant = true,
                            Rating = 2
                        },
                        new
                        {
                            CompetenceId = new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"),
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
                            IsRelevant = true,
                            Rating = 4
                        },
                        new
                        {
                            CompetenceId = new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"),
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
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
                            EducationId = new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"),
                            KonsultantId = new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"),
                            EndDate = new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRelevant = true,
                            StartDate = new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EducationId = new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"),
                            KonsultantId = new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"),
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
