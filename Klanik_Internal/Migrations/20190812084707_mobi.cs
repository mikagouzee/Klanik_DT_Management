using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class mobi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Mobilites",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MobilityId = table.Column<Guid>(nullable: false),
                    CountriId = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    BusinessUnit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobilites", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mobilites");

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
    }
}
