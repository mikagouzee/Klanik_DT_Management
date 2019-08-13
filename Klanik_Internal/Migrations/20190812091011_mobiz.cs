using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class mobiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Konsultant_Mobilites_MobilitieId",
                table: "Konsultant");

            migrationBuilder.DropForeignKey(
                name: "FK_Mobilites_Konsultant_KonsultantId",
                table: "Mobilites");

            migrationBuilder.DropIndex(
                name: "IX_Mobilites_KonsultantId",
                table: "Mobilites");

            migrationBuilder.DropIndex(
                name: "IX_Konsultant_MobilitieId",
                table: "Konsultant");

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new Guid("09f0ab67-e697-49d7-a931-be6df43f719b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new Guid("916d2a45-1f95-4995-9bd1-58345f07f15b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new Guid("dde008cc-adc2-4bc6-a081-eeab812bebbf") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new Guid("09f0ab67-e697-49d7-a931-be6df43f719b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new Guid("916d2a45-1f95-4995-9bd1-58345f07f15b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new Guid("dde008cc-adc2-4bc6-a081-eeab812bebbf") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("1f92a584-b669-485d-820d-11a674df8548"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("1f92a584-b669-485d-820d-11a674df8548"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("7d1d5e37-1bc4-496b-b7dd-ebc2b490a90d"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("9149ac80-05e5-4d25-a1a9-e7662e8fecfa"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("65db86a3-ab1c-4fb2-b554-10fc07b4c8f0"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("65db86a3-ab1c-4fb2-b554-10fc07b4c8f0"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("bead11b9-9e17-42ca-b3ff-a54c85e94d7b"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("bead11b9-9e17-42ca-b3ff-a54c85e94d7b"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("33e0255d-2e85-4eab-a584-156bbc862a55"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("abb02070-b51f-431f-9dcb-87661e1c97e8"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("1f92a584-b669-485d-820d-11a674df8548"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("7d1d5e37-1bc4-496b-b7dd-ebc2b490a90d"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("9149ac80-05e5-4d25-a1a9-e7662e8fecfa"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("65db86a3-ab1c-4fb2-b554-10fc07b4c8f0"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("bead11b9-9e17-42ca-b3ff-a54c85e94d7b"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("33e0255d-2e85-4eab-a584-156bbc862a55"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("abb02070-b51f-431f-9dcb-87661e1c97e8"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("09f0ab67-e697-49d7-a931-be6df43f719b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("916d2a45-1f95-4995-9bd1-58345f07f15b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("dde008cc-adc2-4bc6-a081-eeab812bebbf"));

            migrationBuilder.DropColumn(
                name: "KonsultantId",
                table: "Mobilites");

            migrationBuilder.DropColumn(
                name: "MobilitieId",
                table: "Konsultant");

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d800d0c6-8827-4db4-869e-ed9e3fb65314"), "C# certified developer" },
                    { new Guid("2ae220f3-cd15-4750-9f7f-81b9909b2158"), "High School Diploma" },
                    { new Guid("c841504e-a57a-499f-9e8d-a21419249867"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d3145814-a709-483a-b56c-dc416f621594"), "dotNet" },
                    { new Guid("cda67c96-3390-44a9-9100-ae17d5f15d9c"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7186427e-a672-480b-8770-3c15cef479cb"), "SelfTaught" },
                    { new Guid("98781442-0e8b-4f03-b231-a52fe4ac5fba"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new DateTime(2019, 8, 12, 11, 10, 10, 833, DateTimeKind.Local).AddTicks(9705), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("988d51ec-5b93-4cc5-8c76-600df6293409"), "Français" },
                    { new Guid("04335eba-e318-4d4c-93dd-cbc29f8dee89"), "Néerlandais" },
                    { new Guid("5bcd1924-7526-4dd8-bf6f-2524d14233bd"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new Guid("988d51ec-5b93-4cc5-8c76-600df6293409"), 5, true },
                    { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new Guid("988d51ec-5b93-4cc5-8c76-600df6293409"), 5, true },
                    { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new Guid("04335eba-e318-4d4c-93dd-cbc29f8dee89"), 2, true },
                    { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new Guid("04335eba-e318-4d4c-93dd-cbc29f8dee89"), 1, true },
                    { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new Guid("5bcd1924-7526-4dd8-bf6f-2524d14233bd"), 4, true },
                    { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new Guid("5bcd1924-7526-4dd8-bf6f-2524d14233bd"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("d800d0c6-8827-4db4-869e-ed9e3fb65314"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c841504e-a57a-499f-9e8d-a21419249867"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ae220f3-cd15-4750-9f7f-81b9909b2158"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c841504e-a57a-499f-9e8d-a21419249867"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("d3145814-a709-483a-b56c-dc416f621594"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), true, 4 },
                    { new Guid("cda67c96-3390-44a9-9100-ae17d5f15d9c"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), true, 2 },
                    { new Guid("d3145814-a709-483a-b56c-dc416f621594"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), true, 4 },
                    { new Guid("cda67c96-3390-44a9-9100-ae17d5f15d9c"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("7186427e-a672-480b-8770-3c15cef479cb"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98781442-0e8b-4f03-b231-a52fe4ac5fba"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new Guid("04335eba-e318-4d4c-93dd-cbc29f8dee89") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new Guid("5bcd1924-7526-4dd8-bf6f-2524d14233bd") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"), new Guid("988d51ec-5b93-4cc5-8c76-600df6293409") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new Guid("04335eba-e318-4d4c-93dd-cbc29f8dee89") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new Guid("5bcd1924-7526-4dd8-bf6f-2524d14233bd") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"), new Guid("988d51ec-5b93-4cc5-8c76-600df6293409") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("2ae220f3-cd15-4750-9f7f-81b9909b2158"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("c841504e-a57a-499f-9e8d-a21419249867"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("c841504e-a57a-499f-9e8d-a21419249867"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("d800d0c6-8827-4db4-869e-ed9e3fb65314"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("cda67c96-3390-44a9-9100-ae17d5f15d9c"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("cda67c96-3390-44a9-9100-ae17d5f15d9c"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("d3145814-a709-483a-b56c-dc416f621594"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("d3145814-a709-483a-b56c-dc416f621594"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("7186427e-a672-480b-8770-3c15cef479cb"), new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("98781442-0e8b-4f03-b231-a52fe4ac5fba"), new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("2ae220f3-cd15-4750-9f7f-81b9909b2158"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("c841504e-a57a-499f-9e8d-a21419249867"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("d800d0c6-8827-4db4-869e-ed9e3fb65314"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("cda67c96-3390-44a9-9100-ae17d5f15d9c"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("d3145814-a709-483a-b56c-dc416f621594"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("7186427e-a672-480b-8770-3c15cef479cb"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("98781442-0e8b-4f03-b231-a52fe4ac5fba"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("5c0099ff-d9fa-4e5a-9024-a2dc014760f4"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("7855b31f-95da-47a0-80a6-2506ded34bd2"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("04335eba-e318-4d4c-93dd-cbc29f8dee89"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("5bcd1924-7526-4dd8-bf6f-2524d14233bd"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("988d51ec-5b93-4cc5-8c76-600df6293409"));

            migrationBuilder.AddColumn<Guid>(
                name: "KonsultantId",
                table: "Mobilites",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MobilitieId",
                table: "Konsultant",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7d1d5e37-1bc4-496b-b7dd-ebc2b490a90d"), "C# certified developer" },
                    { new Guid("9149ac80-05e5-4d25-a1a9-e7662e8fecfa"), "High School Diploma" },
                    { new Guid("1f92a584-b669-485d-820d-11a674df8548"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bead11b9-9e17-42ca-b3ff-a54c85e94d7b"), "dotNet" },
                    { new Guid("65db86a3-ab1c-4fb2-b554-10fc07b4c8f0"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("abb02070-b51f-431f-9dcb-87661e1c97e8"), "SelfTaught" },
                    { new Guid("33e0255d-2e85-4eab-a584-156bbc862a55"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "MobilitieId", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new DateTime(2019, 8, 12, 11, 2, 27, 676, DateTimeKind.Local).AddTicks(6689), "FullStack .Net Developer", null, "Michel", null, "Gouzee" },
                    { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", null, "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("dde008cc-adc2-4bc6-a081-eeab812bebbf"), "Français" },
                    { new Guid("916d2a45-1f95-4995-9bd1-58345f07f15b"), "Néerlandais" },
                    { new Guid("09f0ab67-e697-49d7-a931-be6df43f719b"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new Guid("dde008cc-adc2-4bc6-a081-eeab812bebbf"), 5, true },
                    { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new Guid("dde008cc-adc2-4bc6-a081-eeab812bebbf"), 5, true },
                    { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new Guid("916d2a45-1f95-4995-9bd1-58345f07f15b"), 2, true },
                    { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new Guid("916d2a45-1f95-4995-9bd1-58345f07f15b"), 1, true },
                    { new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new Guid("09f0ab67-e697-49d7-a931-be6df43f719b"), 4, true },
                    { new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new Guid("09f0ab67-e697-49d7-a931-be6df43f719b"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("7d1d5e37-1bc4-496b-b7dd-ebc2b490a90d"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f92a584-b669-485d-820d-11a674df8548"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9149ac80-05e5-4d25-a1a9-e7662e8fecfa"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f92a584-b669-485d-820d-11a674df8548"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("bead11b9-9e17-42ca-b3ff-a54c85e94d7b"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), true, 4 },
                    { new Guid("65db86a3-ab1c-4fb2-b554-10fc07b4c8f0"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), true, 2 },
                    { new Guid("bead11b9-9e17-42ca-b3ff-a54c85e94d7b"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), true, 4 },
                    { new Guid("65db86a3-ab1c-4fb2-b554-10fc07b4c8f0"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("abb02070-b51f-431f-9dcb-87661e1c97e8"), new Guid("f57eda5d-04b9-4d4f-8763-d79e441242f9"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33e0255d-2e85-4eab-a584-156bbc862a55"), new Guid("9dd46298-9d74-4c6b-b19e-9aca24ba2b15"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobilites_KonsultantId",
                table: "Mobilites",
                column: "KonsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Konsultant_MobilitieId",
                table: "Konsultant",
                column: "MobilitieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Konsultant_Mobilites_MobilitieId",
                table: "Konsultant",
                column: "MobilitieId",
                principalTable: "Mobilites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mobilites_Konsultant_KonsultantId",
                table: "Mobilites",
                column: "KonsultantId",
                principalTable: "Konsultant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
