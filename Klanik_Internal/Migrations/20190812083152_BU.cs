using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class BU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new Guid("49db0149-9460-486c-8dd5-3717916d7e1f") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new Guid("49db0149-9460-486c-8dd5-3717916d7e1f") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("044dfa0b-a500-4789-9ba9-ec7080fa5bd6"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("8ee72fed-7353-4f8f-9268-444a20bf557c"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("3496c212-d906-4052-a99d-d8cb0d0383ad"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("a76ace17-25ce-4886-9f2f-9bb378c690cb"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("044dfa0b-a500-4789-9ba9-ec7080fa5bd6"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("8ee72fed-7353-4f8f-9268-444a20bf557c"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("3496c212-d906-4052-a99d-d8cb0d0383ad"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("a76ace17-25ce-4886-9f2f-9bb378c690cb"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("3974a038-d319-4e3b-8e24-140d2646e497"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("8ee72fed-7353-4f8f-9268-444a20bf557c"), "C# certified developer" },
                    { new Guid("044dfa0b-a500-4789-9ba9-ec7080fa5bd6"), "High School Diploma" },
                    { new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"), "dotNet" },
                    { new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a76ace17-25ce-4886-9f2f-9bb378c690cb"), "SelfTaught" },
                    { new Guid("3496c212-d906-4052-a99d-d8cb0d0383ad"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new DateTime(2019, 6, 12, 14, 4, 15, 268, DateTimeKind.Local).AddTicks(568), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"), "Français" },
                    { new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"), "Néerlandais" },
                    { new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"), 5, true },
                    { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new Guid("49db0149-9460-486c-8dd5-3717916d7e1f"), 5, true },
                    { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"), 2, true },
                    { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new Guid("3f09f17c-b2df-4822-b1e1-6da42338576c"), 1, true },
                    { new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"), 4, true },
                    { new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new Guid("514edce5-6ac2-4519-b2d5-27d7d6879a13"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("8ee72fed-7353-4f8f-9268-444a20bf557c"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("044dfa0b-a500-4789-9ba9-ec7080fa5bd6"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cbc5015e-0132-4876-9d87-130de1f8ad74"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), true, 4 },
                    { new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), true, 2 },
                    { new Guid("0d8d89db-20c8-4739-a1e5-d11a40008337"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), true, 4 },
                    { new Guid("ef2e82f2-92ab-40d9-9868-604d32e76ef2"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a76ace17-25ce-4886-9f2f-9bb378c690cb"), new Guid("3974a038-d319-4e3b-8e24-140d2646e497"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3496c212-d906-4052-a99d-d8cb0d0383ad"), new Guid("6b2dc53d-99c1-495b-8635-3fe4f3773c4c"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
