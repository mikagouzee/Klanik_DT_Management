using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class Add_Company_To_Contact_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("a843d670-80ba-415e-8d65-aca385c2ea19") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("d1de9801-9b62-4246-8d0c-6d716572334c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("a843d670-80ba-415e-8d65-aca385c2ea19") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("d1de9801-9b62-4246-8d0c-6d716572334c") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("80ed29c6-5d20-455e-b7b0-0fbc8b2cd447"), new Guid("6670b486-f434-4328-a96f-334d482297c3") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), new Guid("6670b486-f434-4328-a96f-334d482297c3") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("de9de72f-3147-4002-974c-d01eeb071de2"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), new Guid("6670b486-f434-4328-a96f-334d482297c3") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), new Guid("6670b486-f434-4328-a96f-334d482297c3") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("907003f6-5a7d-4461-831a-71437dcedc50"), new Guid("6670b486-f434-4328-a96f-334d482297c3") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("d2a8ccbd-0089-483f-b1c8-ea4a005dab32"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("80ed29c6-5d20-455e-b7b0-0fbc8b2cd447"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("de9de72f-3147-4002-974c-d01eeb071de2"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("d22768fe-3e98-417e-a96d-6b465645b883"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("907003f6-5a7d-4461-831a-71437dcedc50"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("d2a8ccbd-0089-483f-b1c8-ea4a005dab32"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("6670b486-f434-4328-a96f-334d482297c3"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"));

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "ProfessionalReference",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ac5b0c10-f5c2-47a7-9193-d806d706a98e"), "C# certified developer" },
                    { new Guid("f8181951-069e-4546-90f3-887fbce7048f"), "High School Diploma" },
                    { new Guid("e8242396-0609-4cf0-b67d-93c8f50faa02"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("78a94eb7-230b-4ea4-8415-58382a882862"), "dotNet" },
                    { new Guid("0eba33ba-9336-4dff-b6e3-1837e62f0198"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7a8dfb8c-87f0-4d59-bf63-062cfb10e7cc"), "SelfTaught" },
                    { new Guid("b1b145a4-2dd5-4ccc-a695-1e2fdda93d89"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new DateTime(2019, 5, 20, 12, 3, 37, 570, DateTimeKind.Local).AddTicks(1423), "FullStack .Net Developer", "Michel", "Gouzee" },
                    { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b5e9eb3f-2dd7-4d97-af9b-3367d533890c"), "Français" },
                    { new Guid("793645e5-a007-4315-a6cf-ff01eedd5960"), "Néerlandais" },
                    { new Guid("a378f306-b323-4178-9768-0e23a153cb93"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new Guid("b5e9eb3f-2dd7-4d97-af9b-3367d533890c"), 5, true },
                    { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new Guid("b5e9eb3f-2dd7-4d97-af9b-3367d533890c"), 5, true },
                    { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new Guid("793645e5-a007-4315-a6cf-ff01eedd5960"), 2, true },
                    { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new Guid("793645e5-a007-4315-a6cf-ff01eedd5960"), 1, true },
                    { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new Guid("a378f306-b323-4178-9768-0e23a153cb93"), 4, true },
                    { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new Guid("a378f306-b323-4178-9768-0e23a153cb93"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("ac5b0c10-f5c2-47a7-9193-d806d706a98e"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8242396-0609-4cf0-b67d-93c8f50faa02"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8181951-069e-4546-90f3-887fbce7048f"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8242396-0609-4cf0-b67d-93c8f50faa02"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("78a94eb7-230b-4ea4-8415-58382a882862"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), true, 4 },
                    { new Guid("0eba33ba-9336-4dff-b6e3-1837e62f0198"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), true, 2 },
                    { new Guid("78a94eb7-230b-4ea4-8415-58382a882862"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), true, 4 },
                    { new Guid("0eba33ba-9336-4dff-b6e3-1837e62f0198"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("7a8dfb8c-87f0-4d59-bf63-062cfb10e7cc"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1b145a4-2dd5-4ccc-a695-1e2fdda93d89"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new Guid("793645e5-a007-4315-a6cf-ff01eedd5960") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new Guid("a378f306-b323-4178-9768-0e23a153cb93") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"), new Guid("b5e9eb3f-2dd7-4d97-af9b-3367d533890c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new Guid("793645e5-a007-4315-a6cf-ff01eedd5960") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new Guid("a378f306-b323-4178-9768-0e23a153cb93") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"), new Guid("b5e9eb3f-2dd7-4d97-af9b-3367d533890c") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("ac5b0c10-f5c2-47a7-9193-d806d706a98e"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("e8242396-0609-4cf0-b67d-93c8f50faa02"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("e8242396-0609-4cf0-b67d-93c8f50faa02"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("f8181951-069e-4546-90f3-887fbce7048f"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("0eba33ba-9336-4dff-b6e3-1837e62f0198"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("0eba33ba-9336-4dff-b6e3-1837e62f0198"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("78a94eb7-230b-4ea4-8415-58382a882862"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("78a94eb7-230b-4ea4-8415-58382a882862"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("7a8dfb8c-87f0-4d59-bf63-062cfb10e7cc"), new Guid("24e33535-5324-4d22-9f4d-f54b72535d47") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("b1b145a4-2dd5-4ccc-a695-1e2fdda93d89"), new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("ac5b0c10-f5c2-47a7-9193-d806d706a98e"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("e8242396-0609-4cf0-b67d-93c8f50faa02"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("f8181951-069e-4546-90f3-887fbce7048f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("0eba33ba-9336-4dff-b6e3-1837e62f0198"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("78a94eb7-230b-4ea4-8415-58382a882862"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("7a8dfb8c-87f0-4d59-bf63-062cfb10e7cc"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("b1b145a4-2dd5-4ccc-a695-1e2fdda93d89"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("24e33535-5324-4d22-9f4d-f54b72535d47"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("e4e83fa4-3350-4453-b9f0-7515dbf6e393"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("793645e5-a007-4315-a6cf-ff01eedd5960"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("a378f306-b323-4178-9768-0e23a153cb93"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("b5e9eb3f-2dd7-4d97-af9b-3367d533890c"));

            migrationBuilder.DropColumn(
                name: "Company",
                table: "ProfessionalReference");

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("80ed29c6-5d20-455e-b7b0-0fbc8b2cd447"), "C# certified developer" },
                    { new Guid("de9de72f-3147-4002-974c-d01eeb071de2"), "High School Diploma" },
                    { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), "dotNet" },
                    { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("907003f6-5a7d-4461-831a-71437dcedc50"), "SelfTaught" },
                    { new Guid("d2a8ccbd-0089-483f-b1c8-ea4a005dab32"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2019, 5, 15, 11, 5, 40, 180, DateTimeKind.Local).AddTicks(2034), "FullStack .Net Developer", "Michel", "Gouzee" },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"), "Français" },
                    { new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"), "Néerlandais" },
                    { new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"), 5, false },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"), 5, false },
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"), 2, false },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"), 1, false },
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"), 4, false },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"), 4, false }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("80ed29c6-5d20-455e-b7b0-0fbc8b2cd447"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de9de72f-3147-4002-974c-d01eeb071de2"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), false, 4 },
                    { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), false, 2 },
                    { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), false, 4 },
                    { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), false, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("907003f6-5a7d-4461-831a-71437dcedc50"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2a8ccbd-0089-483f-b1c8-ea4a005dab32"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
