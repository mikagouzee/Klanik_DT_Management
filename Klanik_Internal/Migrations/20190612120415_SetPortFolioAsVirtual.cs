using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class SetPortFolioAsVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new Guid("29d934ee-45ff-4ffb-95b2-86818020e09c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new Guid("425a1fb4-590c-4061-b81b-0da54fc3f1af") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new Guid("c597bc24-1879-46d4-948a-a875c78138ec") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new Guid("29d934ee-45ff-4ffb-95b2-86818020e09c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new Guid("425a1fb4-590c-4061-b81b-0da54fc3f1af") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new Guid("c597bc24-1879-46d4-948a-a875c78138ec") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("50d7d8f7-5b1e-4ead-8cb3-9157955174fd"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("8736651c-c540-444c-82ee-40e53611e88f"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("8736651c-c540-444c-82ee-40e53611e88f"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("ea562119-f016-419a-bf10-816eea00f660"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("341a84f5-73e4-4f89-bee8-12e8c4b46fd8"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("341a84f5-73e4-4f89-bee8-12e8c4b46fd8"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("ac76d66f-c8fe-49c7-80bc-7cf6eea53cc6"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("ac76d66f-c8fe-49c7-80bc-7cf6eea53cc6"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("2c214277-99c2-41ca-8af1-65738c420928"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("a206a2ff-9867-452a-97c3-a43f36121516"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("50d7d8f7-5b1e-4ead-8cb3-9157955174fd"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("8736651c-c540-444c-82ee-40e53611e88f"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("ea562119-f016-419a-bf10-816eea00f660"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("341a84f5-73e4-4f89-bee8-12e8c4b46fd8"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("ac76d66f-c8fe-49c7-80bc-7cf6eea53cc6"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("2c214277-99c2-41ca-8af1-65738c420928"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("a206a2ff-9867-452a-97c3-a43f36121516"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("29d934ee-45ff-4ffb-95b2-86818020e09c"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("425a1fb4-590c-4061-b81b-0da54fc3f1af"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("c597bc24-1879-46d4-948a-a875c78138ec"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("ea562119-f016-419a-bf10-816eea00f660"), "C# certified developer" },
                    { new Guid("50d7d8f7-5b1e-4ead-8cb3-9157955174fd"), "High School Diploma" },
                    { new Guid("8736651c-c540-444c-82ee-40e53611e88f"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ac76d66f-c8fe-49c7-80bc-7cf6eea53cc6"), "dotNet" },
                    { new Guid("341a84f5-73e4-4f89-bee8-12e8c4b46fd8"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a206a2ff-9867-452a-97c3-a43f36121516"), "SelfTaught" },
                    { new Guid("2c214277-99c2-41ca-8af1-65738c420928"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new DateTime(2019, 6, 12, 13, 11, 15, 696, DateTimeKind.Local).AddTicks(1541), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c597bc24-1879-46d4-948a-a875c78138ec"), "Français" },
                    { new Guid("425a1fb4-590c-4061-b81b-0da54fc3f1af"), "Néerlandais" },
                    { new Guid("29d934ee-45ff-4ffb-95b2-86818020e09c"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new Guid("c597bc24-1879-46d4-948a-a875c78138ec"), 5, true },
                    { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new Guid("c597bc24-1879-46d4-948a-a875c78138ec"), 5, true },
                    { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new Guid("425a1fb4-590c-4061-b81b-0da54fc3f1af"), 2, true },
                    { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new Guid("425a1fb4-590c-4061-b81b-0da54fc3f1af"), 1, true },
                    { new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new Guid("29d934ee-45ff-4ffb-95b2-86818020e09c"), 4, true },
                    { new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new Guid("29d934ee-45ff-4ffb-95b2-86818020e09c"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("ea562119-f016-419a-bf10-816eea00f660"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8736651c-c540-444c-82ee-40e53611e88f"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50d7d8f7-5b1e-4ead-8cb3-9157955174fd"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8736651c-c540-444c-82ee-40e53611e88f"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("ac76d66f-c8fe-49c7-80bc-7cf6eea53cc6"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), true, 4 },
                    { new Guid("341a84f5-73e4-4f89-bee8-12e8c4b46fd8"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), true, 2 },
                    { new Guid("ac76d66f-c8fe-49c7-80bc-7cf6eea53cc6"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), true, 4 },
                    { new Guid("341a84f5-73e4-4f89-bee8-12e8c4b46fd8"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a206a2ff-9867-452a-97c3-a43f36121516"), new Guid("b4a9ba8c-2ec5-4be1-8903-c683af49509e"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c214277-99c2-41ca-8af1-65738c420928"), new Guid("1bd32504-135e-435b-9d6a-96b155c1c7b8"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
