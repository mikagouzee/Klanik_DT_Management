using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class CorrectMappingRecruiter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new Guid("7b854218-2f77-49f5-a3f3-43b231607d4b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new Guid("d8fe7c30-a7d8-4ccf-a2d5-e86198aa4b9b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new Guid("e235a36b-7da0-4320-b608-5b85118ce6e8") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new Guid("7b854218-2f77-49f5-a3f3-43b231607d4b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new Guid("d8fe7c30-a7d8-4ccf-a2d5-e86198aa4b9b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new Guid("e235a36b-7da0-4320-b608-5b85118ce6e8") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("1fb1ae54-6a03-453e-bd84-3dd280fbafcb"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5264c152-bc8e-4bb2-a095-fed03f361203"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5264c152-bc8e-4bb2-a095-fed03f361203"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("53240e96-074a-44cd-8db2-7225262cce9a"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("2094fd55-c21a-4ef9-b765-7c9a01ea9926"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("2094fd55-c21a-4ef9-b765-7c9a01ea9926"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("29b9f445-21fe-4a31-bccd-4ff0ffd94d55"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("29b9f445-21fe-4a31-bccd-4ff0ffd94d55"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("bae28b26-114e-4903-ab39-9752110c68dd"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("e9b4f366-a13b-44ce-a74e-fe20c852c876"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("1fb1ae54-6a03-453e-bd84-3dd280fbafcb"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("5264c152-bc8e-4bb2-a095-fed03f361203"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("53240e96-074a-44cd-8db2-7225262cce9a"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("2094fd55-c21a-4ef9-b765-7c9a01ea9926"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("29b9f445-21fe-4a31-bccd-4ff0ffd94d55"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("bae28b26-114e-4903-ab39-9752110c68dd"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("e9b4f366-a13b-44ce-a74e-fe20c852c876"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("7b854218-2f77-49f5-a3f3-43b231607d4b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("d8fe7c30-a7d8-4ccf-a2d5-e86198aa4b9b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("e235a36b-7da0-4320-b608-5b85118ce6e8"));

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
                table: "Recruiter",
                columns: new[] { "Id", "ContactId", "Name", "Surname" },
                values: new object[] { new Guid("d2004e8d-aa24-4c04-a2ed-4e4a475a1cc8"), null, "Michel", "Gouzee" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: new Guid("d2004e8d-aa24-4c04-a2ed-4e4a475a1cc8"));

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
                    { new Guid("53240e96-074a-44cd-8db2-7225262cce9a"), "C# certified developer" },
                    { new Guid("1fb1ae54-6a03-453e-bd84-3dd280fbafcb"), "High School Diploma" },
                    { new Guid("5264c152-bc8e-4bb2-a095-fed03f361203"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("29b9f445-21fe-4a31-bccd-4ff0ffd94d55"), "dotNet" },
                    { new Guid("2094fd55-c21a-4ef9-b765-7c9a01ea9926"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e9b4f366-a13b-44ce-a74e-fe20c852c876"), "SelfTaught" },
                    { new Guid("bae28b26-114e-4903-ab39-9752110c68dd"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new DateTime(2019, 6, 12, 10, 25, 12, 746, DateTimeKind.Local).AddTicks(1641), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e235a36b-7da0-4320-b608-5b85118ce6e8"), "Français" },
                    { new Guid("d8fe7c30-a7d8-4ccf-a2d5-e86198aa4b9b"), "Néerlandais" },
                    { new Guid("7b854218-2f77-49f5-a3f3-43b231607d4b"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new Guid("e235a36b-7da0-4320-b608-5b85118ce6e8"), 5, true },
                    { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new Guid("e235a36b-7da0-4320-b608-5b85118ce6e8"), 5, true },
                    { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new Guid("d8fe7c30-a7d8-4ccf-a2d5-e86198aa4b9b"), 2, true },
                    { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new Guid("d8fe7c30-a7d8-4ccf-a2d5-e86198aa4b9b"), 1, true },
                    { new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new Guid("7b854218-2f77-49f5-a3f3-43b231607d4b"), 4, true },
                    { new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new Guid("7b854218-2f77-49f5-a3f3-43b231607d4b"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("53240e96-074a-44cd-8db2-7225262cce9a"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5264c152-bc8e-4bb2-a095-fed03f361203"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1fb1ae54-6a03-453e-bd84-3dd280fbafcb"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5264c152-bc8e-4bb2-a095-fed03f361203"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("29b9f445-21fe-4a31-bccd-4ff0ffd94d55"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), true, 4 },
                    { new Guid("2094fd55-c21a-4ef9-b765-7c9a01ea9926"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), true, 2 },
                    { new Guid("29b9f445-21fe-4a31-bccd-4ff0ffd94d55"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), true, 4 },
                    { new Guid("2094fd55-c21a-4ef9-b765-7c9a01ea9926"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("e9b4f366-a13b-44ce-a74e-fe20c852c876"), new Guid("8fc23b47-3d50-4783-a2f8-e850a92e478e"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bae28b26-114e-4903-ab39-9752110c68dd"), new Guid("eefaacd9-6acd-42ce-9e21-64e598d7c577"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
