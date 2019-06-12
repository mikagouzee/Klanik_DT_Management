using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class AddOptIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "OptIn",
                table: "Konsultant",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b9755075-c326-42c1-87ae-b6fc69c7550f"), "C# certified developer" },
                    { new Guid("ce4db6a0-f5f0-496c-a377-e0af4cfaf16c"), "High School Diploma" },
                    { new Guid("fa8d54fd-59e2-4048-9f30-09c2ba6d2ac1"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3440934a-c944-4204-95a6-7fc2faf2b16f"), "dotNet" },
                    { new Guid("b7a3b9f2-156e-4a53-ba34-67c046716d98"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ec92beda-34f5-428c-8656-6df0b89f8a4e"), "SelfTaught" },
                    { new Guid("0edcaaa4-2496-49b9-956f-66713860ecc9"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "OptIn", "Surname" },
                values: new object[,]
                {
                    { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new DateTime(2019, 6, 11, 8, 5, 47, 942, DateTimeKind.Local).AddTicks(1886), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("db95f0ee-6f10-4160-82e3-fdf07fe16b1b"), "Français" },
                    { new Guid("7f8ecf3e-a470-43be-a2ab-fafc246dd4aa"), "Néerlandais" },
                    { new Guid("192b8348-7fb7-4598-b56b-67e2463513c8"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new Guid("db95f0ee-6f10-4160-82e3-fdf07fe16b1b"), 5, true },
                    { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new Guid("db95f0ee-6f10-4160-82e3-fdf07fe16b1b"), 5, true },
                    { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new Guid("7f8ecf3e-a470-43be-a2ab-fafc246dd4aa"), 2, true },
                    { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new Guid("7f8ecf3e-a470-43be-a2ab-fafc246dd4aa"), 1, true },
                    { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new Guid("192b8348-7fb7-4598-b56b-67e2463513c8"), 4, true },
                    { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new Guid("192b8348-7fb7-4598-b56b-67e2463513c8"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("b9755075-c326-42c1-87ae-b6fc69c7550f"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa8d54fd-59e2-4048-9f30-09c2ba6d2ac1"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce4db6a0-f5f0-496c-a377-e0af4cfaf16c"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa8d54fd-59e2-4048-9f30-09c2ba6d2ac1"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("3440934a-c944-4204-95a6-7fc2faf2b16f"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), true, 4 },
                    { new Guid("b7a3b9f2-156e-4a53-ba34-67c046716d98"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), true, 2 },
                    { new Guid("3440934a-c944-4204-95a6-7fc2faf2b16f"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), true, 4 },
                    { new Guid("b7a3b9f2-156e-4a53-ba34-67c046716d98"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("ec92beda-34f5-428c-8656-6df0b89f8a4e"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0edcaaa4-2496-49b9-956f-66713860ecc9"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new Guid("192b8348-7fb7-4598-b56b-67e2463513c8") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new Guid("7f8ecf3e-a470-43be-a2ab-fafc246dd4aa") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"), new Guid("db95f0ee-6f10-4160-82e3-fdf07fe16b1b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new Guid("192b8348-7fb7-4598-b56b-67e2463513c8") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new Guid("7f8ecf3e-a470-43be-a2ab-fafc246dd4aa") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"), new Guid("db95f0ee-6f10-4160-82e3-fdf07fe16b1b") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("b9755075-c326-42c1-87ae-b6fc69c7550f"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("ce4db6a0-f5f0-496c-a377-e0af4cfaf16c"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("fa8d54fd-59e2-4048-9f30-09c2ba6d2ac1"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("fa8d54fd-59e2-4048-9f30-09c2ba6d2ac1"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("3440934a-c944-4204-95a6-7fc2faf2b16f"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("3440934a-c944-4204-95a6-7fc2faf2b16f"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("b7a3b9f2-156e-4a53-ba34-67c046716d98"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("b7a3b9f2-156e-4a53-ba34-67c046716d98"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("0edcaaa4-2496-49b9-956f-66713860ecc9"), new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("ec92beda-34f5-428c-8656-6df0b89f8a4e"), new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("b9755075-c326-42c1-87ae-b6fc69c7550f"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("ce4db6a0-f5f0-496c-a377-e0af4cfaf16c"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("fa8d54fd-59e2-4048-9f30-09c2ba6d2ac1"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("3440934a-c944-4204-95a6-7fc2faf2b16f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("b7a3b9f2-156e-4a53-ba34-67c046716d98"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("0edcaaa4-2496-49b9-956f-66713860ecc9"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("ec92beda-34f5-428c-8656-6df0b89f8a4e"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("3636efd7-bfaf-4598-9abb-21108abbe47e"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("a8e0e016-21a6-4766-bbad-d88de6da5c25"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("192b8348-7fb7-4598-b56b-67e2463513c8"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("7f8ecf3e-a470-43be-a2ab-fafc246dd4aa"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("db95f0ee-6f10-4160-82e3-fdf07fe16b1b"));

            migrationBuilder.DropColumn(
                name: "OptIn",
                table: "Konsultant");

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
    }
}
