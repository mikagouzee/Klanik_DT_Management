using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class removedoptin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"), "C# certified developer" },
                    { new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"), "High School Diploma" },
                    { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), "dotNet" },
                    { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"), "SelfTaught" },
                    { new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2019, 6, 11, 15, 8, 30, 555, DateTimeKind.Local).AddTicks(2842), "FullStack .Net Developer", "Michel", "Gouzee" },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"), "Français" },
                    { new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"), "Néerlandais" },
                    { new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"), 5, true },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"), 5, true },
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"), 2, true },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"), 1, true },
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"), 4, true },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), true, 4 },
                    { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), true, 2 },
                    { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), true, 4 },
                    { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("76ff0398-028c-438c-8ad1-9584f0972522"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"));

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
    }
}
