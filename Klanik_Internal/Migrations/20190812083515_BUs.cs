using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class BUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new Guid("265eb676-873f-444f-a066-3422cb3cf33f") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new Guid("3adbd371-472f-4229-b290-f408ade231c8") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new Guid("265eb676-873f-444f-a066-3422cb3cf33f") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new Guid("3adbd371-472f-4229-b290-f408ade231c8") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"), new Guid("52d08ade-6714-403f-bb89-59b3da309649") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("62dc7fb4-93e1-405c-9180-af140e2483de"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("88d5b4bb-022e-4204-97ab-02d16e94a1f9"), new Guid("52d08ade-6714-403f-bb89-59b3da309649") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"), new Guid("52d08ade-6714-403f-bb89-59b3da309649") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"), new Guid("52d08ade-6714-403f-bb89-59b3da309649") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("51757372-be54-4fe3-9d00-16a8eb8f67b9"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("ea527782-e31e-49ac-b2a6-3b6fa617569d"), new Guid("52d08ade-6714-403f-bb89-59b3da309649") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("62dc7fb4-93e1-405c-9180-af140e2483de"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("88d5b4bb-022e-4204-97ab-02d16e94a1f9"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("51757372-be54-4fe3-9d00-16a8eb8f67b9"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("ea527782-e31e-49ac-b2a6-3b6fa617569d"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("52d08ade-6714-403f-bb89-59b3da309649"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("265eb676-873f-444f-a066-3422cb3cf33f"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("3adbd371-472f-4229-b290-f408ade231c8"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("62dc7fb4-93e1-405c-9180-af140e2483de"), "C# certified developer" },
                    { new Guid("88d5b4bb-022e-4204-97ab-02d16e94a1f9"), "High School Diploma" },
                    { new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"), "dotNet" },
                    { new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("51757372-be54-4fe3-9d00-16a8eb8f67b9"), "SelfTaught" },
                    { new Guid("ea527782-e31e-49ac-b2a6-3b6fa617569d"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new DateTime(2019, 8, 12, 10, 31, 51, 627, DateTimeKind.Local).AddTicks(4511), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"), "Français" },
                    { new Guid("265eb676-873f-444f-a066-3422cb3cf33f"), "Néerlandais" },
                    { new Guid("3adbd371-472f-4229-b290-f408ade231c8"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"), 5, true },
                    { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new Guid("091e9d28-7d87-4e52-817d-a3f47510d00a"), 5, true },
                    { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new Guid("265eb676-873f-444f-a066-3422cb3cf33f"), 2, true },
                    { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new Guid("265eb676-873f-444f-a066-3422cb3cf33f"), 1, true },
                    { new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new Guid("3adbd371-472f-4229-b290-f408ade231c8"), 4, true },
                    { new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new Guid("3adbd371-472f-4229-b290-f408ade231c8"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("62dc7fb4-93e1-405c-9180-af140e2483de"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88d5b4bb-022e-4204-97ab-02d16e94a1f9"), new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09f59cb4-d048-46c0-b77b-34152bd83d67"), new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), true, 4 },
                    { new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), true, 2 },
                    { new Guid("5253e450-68ca-4dc4-86f8-1f031892cb64"), new Guid("52d08ade-6714-403f-bb89-59b3da309649"), true, 4 },
                    { new Guid("50736e3f-7611-4d1c-89e1-f550c07972da"), new Guid("52d08ade-6714-403f-bb89-59b3da309649"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("51757372-be54-4fe3-9d00-16a8eb8f67b9"), new Guid("968e709b-ec5d-4608-be54-508697c3e3a4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea527782-e31e-49ac-b2a6-3b6fa617569d"), new Guid("52d08ade-6714-403f-bb89-59b3da309649"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
