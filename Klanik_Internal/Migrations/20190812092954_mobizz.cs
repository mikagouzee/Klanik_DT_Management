using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class mobizz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "KonsultantMobility",
                columns: table => new
                {
                    KonsultantId = table.Column<Guid>(nullable: false),
                    MobilityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonsultantMobility", x => new { x.KonsultantId, x.MobilityId });
                    table.ForeignKey(
                        name: "FK_KonsultantMobility_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonsultantMobility_Mobilites_MobilityId",
                        column: x => x.MobilityId,
                        principalTable: "Mobilites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b8616c64-09e1-42de-bd62-75646d2a18a1"), "C# certified developer" },
                    { new Guid("2459d084-fb56-4fbf-b0de-f6ad862300e1"), "High School Diploma" },
                    { new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"), "dotNet" },
                    { new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("eeffe8d5-0856-4d7a-865a-3e73cf8b88e2"), "SelfTaught" },
                    { new Guid("0f2fbb4f-3500-40f4-b94b-2ca5fdd99ff9"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new DateTime(2019, 8, 12, 11, 29, 54, 104, DateTimeKind.Local).AddTicks(7293), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"), "Français" },
                    { new Guid("7b32694b-73e3-4185-801c-3433cce3a667"), "Néerlandais" },
                    { new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"), 5, true },
                    { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"), 5, true },
                    { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new Guid("7b32694b-73e3-4185-801c-3433cce3a667"), 2, true },
                    { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new Guid("7b32694b-73e3-4185-801c-3433cce3a667"), 1, true },
                    { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"), 4, true },
                    { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("b8616c64-09e1-42de-bd62-75646d2a18a1"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2459d084-fb56-4fbf-b0de-f6ad862300e1"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), true, 4 },
                    { new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), true, 2 },
                    { new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), true, 4 },
                    { new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("eeffe8d5-0856-4d7a-865a-3e73cf8b88e2"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f2fbb4f-3500-40f4-b94b-2ca5fdd99ff9"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KonsultantMobility_MobilityId",
                table: "KonsultantMobility",
                column: "MobilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KonsultantMobility");

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new Guid("7b32694b-73e3-4185-801c-3433cce3a667") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"), new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new Guid("7b32694b-73e3-4185-801c-3433cce3a667") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"), new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("2459d084-fb56-4fbf-b0de-f6ad862300e1"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("b8616c64-09e1-42de-bd62-75646d2a18a1"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("0f2fbb4f-3500-40f4-b94b-2ca5fdd99ff9"), new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("eeffe8d5-0856-4d7a-865a-3e73cf8b88e2"), new Guid("3bcf6346-9bd7-431d-820d-0078363983cd") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("2459d084-fb56-4fbf-b0de-f6ad862300e1"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("b8616c64-09e1-42de-bd62-75646d2a18a1"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("bf2b33bd-376f-4e98-beed-78005575fb0f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("9ca84452-ce66-4bbb-b39b-3b56a121fde2"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("bba576aa-7293-44e3-874f-c61721adaa1c"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("0f2fbb4f-3500-40f4-b94b-2ca5fdd99ff9"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("eeffe8d5-0856-4d7a-865a-3e73cf8b88e2"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("3bcf6346-9bd7-431d-820d-0078363983cd"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("8ba2cf3f-970b-4dd8-add6-7676e7d7066c"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("7b32694b-73e3-4185-801c-3433cce3a667"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("f39ea505-55f2-4ab7-bb8d-6a772e8fbf6a"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("fbc60529-bec0-405b-8f9b-b85cf70a3353"));

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
    }
}
