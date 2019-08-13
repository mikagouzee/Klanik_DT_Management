using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class mob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("8b10a447-c1d2-4042-b346-56f38403f774"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("dac6e6cb-40b3-4378-8ba8-edefa8e6c60f"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("85eab401-bab0-4236-a587-673b792d0aa2"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("85eab401-bab0-4236-a587-673b792d0aa2"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("a5033f9d-a3d9-46ec-96dc-10875830e91a"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("bc26429a-67ca-453b-a209-681b4dc560bd"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("8b10a447-c1d2-4042-b346-56f38403f774"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("dac6e6cb-40b3-4378-8ba8-edefa8e6c60f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("85eab401-bab0-4236-a587-673b792d0aa2"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("a5033f9d-a3d9-46ec-96dc-10875830e91a"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("bc26429a-67ca-453b-a209-681b4dc560bd"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"));

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5e67733e-a211-44e7-b322-d53dc9f069b2"), "C# certified developer" },
                    { new Guid("272286ed-f395-4233-9dee-eff27fd4ee23"), "High School Diploma" },
                    { new Guid("a19bad39-4151-4cdb-9097-7e7098b218f7"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5f189f61-a6e6-4aca-937f-504d73cb59bf"), "dotNet" },
                    { new Guid("346a1209-c717-407d-a470-8fe3112dc92f"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("31e23e85-5acb-42d7-b83a-c1f6f3c86f8c"), "SelfTaught" },
                    { new Guid("2ba352de-b399-4109-a32d-3e21b3c2ea50"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new DateTime(2019, 8, 12, 10, 44, 23, 330, DateTimeKind.Local).AddTicks(7923), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ba324bd8-8a5b-441c-a245-2d9529cbea76"), "Français" },
                    { new Guid("97de824c-3256-43de-b812-0e5038a9b3b2"), "Néerlandais" },
                    { new Guid("a46a6337-930f-4ec1-a63f-771faca299f0"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new Guid("ba324bd8-8a5b-441c-a245-2d9529cbea76"), 5, true },
                    { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new Guid("ba324bd8-8a5b-441c-a245-2d9529cbea76"), 5, true },
                    { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new Guid("97de824c-3256-43de-b812-0e5038a9b3b2"), 2, true },
                    { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new Guid("97de824c-3256-43de-b812-0e5038a9b3b2"), 1, true },
                    { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new Guid("a46a6337-930f-4ec1-a63f-771faca299f0"), 4, true },
                    { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new Guid("a46a6337-930f-4ec1-a63f-771faca299f0"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("5e67733e-a211-44e7-b322-d53dc9f069b2"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a19bad39-4151-4cdb-9097-7e7098b218f7"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("272286ed-f395-4233-9dee-eff27fd4ee23"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a19bad39-4151-4cdb-9097-7e7098b218f7"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("5f189f61-a6e6-4aca-937f-504d73cb59bf"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), true, 4 },
                    { new Guid("346a1209-c717-407d-a470-8fe3112dc92f"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), true, 2 },
                    { new Guid("5f189f61-a6e6-4aca-937f-504d73cb59bf"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), true, 4 },
                    { new Guid("346a1209-c717-407d-a470-8fe3112dc92f"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("31e23e85-5acb-42d7-b83a-c1f6f3c86f8c"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ba352de-b399-4109-a32d-3e21b3c2ea50"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new Guid("97de824c-3256-43de-b812-0e5038a9b3b2") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new Guid("a46a6337-930f-4ec1-a63f-771faca299f0") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"), new Guid("ba324bd8-8a5b-441c-a245-2d9529cbea76") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new Guid("97de824c-3256-43de-b812-0e5038a9b3b2") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new Guid("a46a6337-930f-4ec1-a63f-771faca299f0") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"), new Guid("ba324bd8-8a5b-441c-a245-2d9529cbea76") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("272286ed-f395-4233-9dee-eff27fd4ee23"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5e67733e-a211-44e7-b322-d53dc9f069b2"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("a19bad39-4151-4cdb-9097-7e7098b218f7"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("a19bad39-4151-4cdb-9097-7e7098b218f7"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("346a1209-c717-407d-a470-8fe3112dc92f"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("346a1209-c717-407d-a470-8fe3112dc92f"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("5f189f61-a6e6-4aca-937f-504d73cb59bf"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("5f189f61-a6e6-4aca-937f-504d73cb59bf"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("2ba352de-b399-4109-a32d-3e21b3c2ea50"), new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("31e23e85-5acb-42d7-b83a-c1f6f3c86f8c"), new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("272286ed-f395-4233-9dee-eff27fd4ee23"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("5e67733e-a211-44e7-b322-d53dc9f069b2"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("a19bad39-4151-4cdb-9097-7e7098b218f7"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("346a1209-c717-407d-a470-8fe3112dc92f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("5f189f61-a6e6-4aca-937f-504d73cb59bf"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("2ba352de-b399-4109-a32d-3e21b3c2ea50"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("31e23e85-5acb-42d7-b83a-c1f6f3c86f8c"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("38d735d1-7783-4165-9201-6fe6e2c10d4f"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("ef069e7e-9a6e-4d9d-9e2b-e3787cfce35f"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("97de824c-3256-43de-b812-0e5038a9b3b2"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("a46a6337-930f-4ec1-a63f-771faca299f0"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("ba324bd8-8a5b-441c-a245-2d9529cbea76"));

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("dac6e6cb-40b3-4378-8ba8-edefa8e6c60f"), "C# certified developer" },
                    { new Guid("8b10a447-c1d2-4042-b346-56f38403f774"), "High School Diploma" },
                    { new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("85eab401-bab0-4236-a587-673b792d0aa2"), "dotNet" },
                    { new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a5033f9d-a3d9-46ec-96dc-10875830e91a"), "SelfTaught" },
                    { new Guid("bc26429a-67ca-453b-a209-681b4dc560bd"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new DateTime(2019, 8, 12, 10, 35, 15, 632, DateTimeKind.Local).AddTicks(7943), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"), "Français" },
                    { new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"), "Néerlandais" },
                    { new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"), 5, true },
                    { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new Guid("a73122ca-f1a2-4e9e-9161-74467bbc0af6"), 5, true },
                    { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"), 2, true },
                    { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new Guid("03d09ee1-b5c8-40d0-a9c6-4c88fe304310"), 1, true },
                    { new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"), 4, true },
                    { new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new Guid("5760f2c0-cb4b-4569-8e5c-4e373e09c641"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("dac6e6cb-40b3-4378-8ba8-edefa8e6c60f"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b10a447-c1d2-4042-b346-56f38403f774"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("315d406b-c421-4a53-b07a-39bae9cd5b02"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("85eab401-bab0-4236-a587-673b792d0aa2"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), true, 4 },
                    { new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), true, 2 },
                    { new Guid("85eab401-bab0-4236-a587-673b792d0aa2"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), true, 4 },
                    { new Guid("107bf44f-79ca-423a-ab6f-5c221ab71325"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a5033f9d-a3d9-46ec-96dc-10875830e91a"), new Guid("100944ed-a584-40aa-9ad0-3617b81e9908"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc26429a-67ca-453b-a209-681b4dc560bd"), new Guid("aa1ddb14-b753-4ed2-978f-f2aec1c98518"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
