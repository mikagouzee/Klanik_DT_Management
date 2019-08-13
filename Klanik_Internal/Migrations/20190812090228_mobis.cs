using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class mobis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new Guid("00aee25a-974a-4004-8352-60eb79581fc5") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new Guid("0b9ed1f9-22e5-4b97-b805-19fdc936b25a") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new Guid("f0647501-b08c-4ee6-9806-37fcbbd492b4") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new Guid("00aee25a-974a-4004-8352-60eb79581fc5") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new Guid("0b9ed1f9-22e5-4b97-b805-19fdc936b25a") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new Guid("f0647501-b08c-4ee6-9806-37fcbbd492b4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("30acabff-2dc7-49fb-a51b-38d5d105b622"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("7a02d63a-3d65-4524-a767-25e2a13df5d5"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("d70f7c69-8fa8-43bd-9525-0bb42d032cb1"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("d70f7c69-8fa8-43bd-9525-0bb42d032cb1"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("5b0cd417-e977-4e8f-8c05-74728584f019"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("5b0cd417-e977-4e8f-8c05-74728584f019"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("84285d98-ef48-4c47-a01d-a7830ece6564"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("84285d98-ef48-4c47-a01d-a7830ece6564"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("0cd4a7e7-0f10-48de-9fb9-ea843c69c34e"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("0d97267f-e31e-4aca-a786-5677a695aa55"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("30acabff-2dc7-49fb-a51b-38d5d105b622"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("7a02d63a-3d65-4524-a767-25e2a13df5d5"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("d70f7c69-8fa8-43bd-9525-0bb42d032cb1"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("5b0cd417-e977-4e8f-8c05-74728584f019"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("84285d98-ef48-4c47-a01d-a7830ece6564"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("0cd4a7e7-0f10-48de-9fb9-ea843c69c34e"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("0d97267f-e31e-4aca-a786-5677a695aa55"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("00aee25a-974a-4004-8352-60eb79581fc5"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("0b9ed1f9-22e5-4b97-b805-19fdc936b25a"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("f0647501-b08c-4ee6-9806-37fcbbd492b4"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("7a02d63a-3d65-4524-a767-25e2a13df5d5"), "C# certified developer" },
                    { new Guid("30acabff-2dc7-49fb-a51b-38d5d105b622"), "High School Diploma" },
                    { new Guid("d70f7c69-8fa8-43bd-9525-0bb42d032cb1"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("84285d98-ef48-4c47-a01d-a7830ece6564"), "dotNet" },
                    { new Guid("5b0cd417-e977-4e8f-8c05-74728584f019"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d97267f-e31e-4aca-a786-5677a695aa55"), "SelfTaught" },
                    { new Guid("0cd4a7e7-0f10-48de-9fb9-ea843c69c34e"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new DateTime(2019, 8, 12, 10, 47, 7, 443, DateTimeKind.Local).AddTicks(5347), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f0647501-b08c-4ee6-9806-37fcbbd492b4"), "Français" },
                    { new Guid("00aee25a-974a-4004-8352-60eb79581fc5"), "Néerlandais" },
                    { new Guid("0b9ed1f9-22e5-4b97-b805-19fdc936b25a"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new Guid("f0647501-b08c-4ee6-9806-37fcbbd492b4"), 5, true },
                    { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new Guid("f0647501-b08c-4ee6-9806-37fcbbd492b4"), 5, true },
                    { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new Guid("00aee25a-974a-4004-8352-60eb79581fc5"), 2, true },
                    { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new Guid("00aee25a-974a-4004-8352-60eb79581fc5"), 1, true },
                    { new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new Guid("0b9ed1f9-22e5-4b97-b805-19fdc936b25a"), 4, true },
                    { new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new Guid("0b9ed1f9-22e5-4b97-b805-19fdc936b25a"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("7a02d63a-3d65-4524-a767-25e2a13df5d5"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d70f7c69-8fa8-43bd-9525-0bb42d032cb1"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30acabff-2dc7-49fb-a51b-38d5d105b622"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d70f7c69-8fa8-43bd-9525-0bb42d032cb1"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("84285d98-ef48-4c47-a01d-a7830ece6564"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), true, 4 },
                    { new Guid("5b0cd417-e977-4e8f-8c05-74728584f019"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), true, 2 },
                    { new Guid("84285d98-ef48-4c47-a01d-a7830ece6564"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), true, 4 },
                    { new Guid("5b0cd417-e977-4e8f-8c05-74728584f019"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("0d97267f-e31e-4aca-a786-5677a695aa55"), new Guid("c9dab5cc-1e86-455a-9da5-3699f52356b9"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cd4a7e7-0f10-48de-9fb9-ea843c69c34e"), new Guid("3c64ad2a-fabd-4e0c-b528-44f94d58be29"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
