using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Klanik_Internal.Migrations {
    public partial class bu_country : Migration {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Mobilites_Countries_ContryId",
            //    table: "Mobilites");

            //migrationBuilder.DropIndex(
            //    name: "IX_Mobilites_ContryId",
            //    table: "Mobilites");

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new Guid("007d9271-0a35-4fef-8efe-7be4070a2b6f") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new Guid("38bcb276-0e8a-4bf4-a22d-dbd77874e0c5") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new Guid("8a1594fe-4997-48f9-aee4-c8b69629be2b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new Guid("007d9271-0a35-4fef-8efe-7be4070a2b6f") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new Guid("38bcb276-0e8a-4bf4-a22d-dbd77874e0c5") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new Guid("8a1594fe-4997-48f9-aee4-c8b69629be2b") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("297a2d46-b65a-4441-bc58-0915155a71bc"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("6cdc87ff-4018-4a07-8abc-078baed07251"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("6cdc87ff-4018-4a07-8abc-078baed07251"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("b2fbe4de-c9e4-407c-8b95-55e756769e7f"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("767e2772-ff38-46dc-b420-20a1e3d686cc"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("767e2772-ff38-46dc-b420-20a1e3d686cc"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("b16ada82-aa19-439f-b220-b84b83623c8f"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("b16ada82-aa19-439f-b220-b84b83623c8f"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("1333f237-8a08-4d9a-bc7b-e2c06d105c6f"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("bfad5383-bcac-4cb6-9a2a-a1610e97c73f"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("297a2d46-b65a-4441-bc58-0915155a71bc"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("6cdc87ff-4018-4a07-8abc-078baed07251"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("b2fbe4de-c9e4-407c-8b95-55e756769e7f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("767e2772-ff38-46dc-b420-20a1e3d686cc"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("b16ada82-aa19-439f-b220-b84b83623c8f"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("1333f237-8a08-4d9a-bc7b-e2c06d105c6f"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("bfad5383-bcac-4cb6-9a2a-a1610e97c73f"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("007d9271-0a35-4fef-8efe-7be4070a2b6f"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("38bcb276-0e8a-4bf4-a22d-dbd77874e0c5"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("8a1594fe-4997-48f9-aee4-c8b69629be2b"));

            //migrationBuilder.DropColumn(
            //    name: "ContryId",
            //    table: "Mobilites");

            //migrationBuilder.RenameColumn(
            //    name: "CountryId",
            //    table: "Mobilites",
            //    newName: "BusinessUnitId");
            migrationBuilder.CreateTable(
         name: "Mobilites",
         columns: table => new
         {
             KonsultantId = table.Column<Guid>(nullable: false),
             BusinessUnitId = table.Column<Guid>(nullable: false),
             ContryId = table.Column<Guid>(nullable: true)
         },
         constraints: table =>
         {
             table.PrimaryKey("PK_Mobilites", x => new { x.KonsultantId, x.BusinessUnitId });
             table.ForeignKey(
                 name: "FK_Mobilites_Countries_ContryId",
                 column: x => x.ContryId,
                 principalTable: "Countries",
                 principalColumn: "Id",
                 onDelete: ReferentialAction.Restrict);
             table.ForeignKey(
                 name: "FK_Mobilites_Konsultant_KonsultantId",
                 column: x => x.KonsultantId,
                 principalTable: "Konsultant",
                 principalColumn: "Id",
                 onDelete: ReferentialAction.Cascade);
         });

            migrationBuilder.CreateTable(
                name: "businessUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ContryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_businessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_businessUnits_Countries_ContryId",
                        column: x => x.ContryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5c3574dc-11f5-4180-9abf-247a67845517"), "C# certified developer" },
                    { new Guid("5addc655-01d3-471e-be4d-21a4ce1fc2a6"), "High School Diploma" },
                    { new Guid("e93c4a20-47a3-4f86-9e06-69d921b17f9f"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("437b95dc-20a6-4f64-a749-ec878c252570"), "dotNet" },
                    { new Guid("302024cd-8349-4ec6-bf9e-14034962e0d0"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("324363c0-664e-476e-96b3-a7c7834b40e9"), "SelfTaught" },
                    { new Guid("25b4e37f-142d-4a0e-98d8-0086079e4ffb"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new DateTime(2019, 8, 23, 8, 51, 44, 40, DateTimeKind.Local).AddTicks(7831), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("15ac1360-b5dd-48a1-ac2b-34ef8fad485c"), "Français" },
                    { new Guid("8e8d9ee9-4eb9-4033-957e-63b03620f166"), "Néerlandais" },
                    { new Guid("2ba69bfe-8f45-42a1-bd4e-9686e78932b3"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new Guid("15ac1360-b5dd-48a1-ac2b-34ef8fad485c"), 5, true },
                    { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new Guid("15ac1360-b5dd-48a1-ac2b-34ef8fad485c"), 5, true },
                    { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new Guid("8e8d9ee9-4eb9-4033-957e-63b03620f166"), 2, true },
                    { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new Guid("8e8d9ee9-4eb9-4033-957e-63b03620f166"), 1, true },
                    { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new Guid("2ba69bfe-8f45-42a1-bd4e-9686e78932b3"), 4, true },
                    { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new Guid("2ba69bfe-8f45-42a1-bd4e-9686e78932b3"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("5c3574dc-11f5-4180-9abf-247a67845517"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e93c4a20-47a3-4f86-9e06-69d921b17f9f"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5addc655-01d3-471e-be4d-21a4ce1fc2a6"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e93c4a20-47a3-4f86-9e06-69d921b17f9f"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("437b95dc-20a6-4f64-a749-ec878c252570"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), true, 4 },
                    { new Guid("302024cd-8349-4ec6-bf9e-14034962e0d0"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), true, 2 },
                    { new Guid("437b95dc-20a6-4f64-a749-ec878c252570"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), true, 4 },
                    { new Guid("302024cd-8349-4ec6-bf9e-14034962e0d0"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("324363c0-664e-476e-96b3-a7c7834b40e9"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25b4e37f-142d-4a0e-98d8-0086079e4ffb"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobilites_BusinessUnitId",
                table: "Mobilites",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_businessUnits_ContryId",
                table: "businessUnits",
                column: "ContryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobilites_businessUnits_BusinessUnitId",
                table: "Mobilites",
                column: "BusinessUnitId",
                principalTable: "businessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mobilites_businessUnits_BusinessUnitId",
                table: "Mobilites");

            migrationBuilder.DropTable(
                name: "businessUnits");

            migrationBuilder.DropIndex(
                name: "IX_Mobilites_BusinessUnitId",
                table: "Mobilites");

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new Guid("15ac1360-b5dd-48a1-ac2b-34ef8fad485c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new Guid("2ba69bfe-8f45-42a1-bd4e-9686e78932b3") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"), new Guid("8e8d9ee9-4eb9-4033-957e-63b03620f166") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new Guid("15ac1360-b5dd-48a1-ac2b-34ef8fad485c") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new Guid("2ba69bfe-8f45-42a1-bd4e-9686e78932b3") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"), new Guid("8e8d9ee9-4eb9-4033-957e-63b03620f166") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5addc655-01d3-471e-be4d-21a4ce1fc2a6"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5c3574dc-11f5-4180-9abf-247a67845517"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("e93c4a20-47a3-4f86-9e06-69d921b17f9f"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("e93c4a20-47a3-4f86-9e06-69d921b17f9f"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("302024cd-8349-4ec6-bf9e-14034962e0d0"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("302024cd-8349-4ec6-bf9e-14034962e0d0"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("437b95dc-20a6-4f64-a749-ec878c252570"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("437b95dc-20a6-4f64-a749-ec878c252570"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("25b4e37f-142d-4a0e-98d8-0086079e4ffb"), new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("324363c0-664e-476e-96b3-a7c7834b40e9"), new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("5addc655-01d3-471e-be4d-21a4ce1fc2a6"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("5c3574dc-11f5-4180-9abf-247a67845517"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("e93c4a20-47a3-4f86-9e06-69d921b17f9f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("302024cd-8349-4ec6-bf9e-14034962e0d0"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("437b95dc-20a6-4f64-a749-ec878c252570"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("25b4e37f-142d-4a0e-98d8-0086079e4ffb"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("324363c0-664e-476e-96b3-a7c7834b40e9"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("08c3d0ec-f0d8-4921-b63a-8585128a7fb4"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("9b604c46-cddd-40a1-8d94-4428fe9b21f1"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("15ac1360-b5dd-48a1-ac2b-34ef8fad485c"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("2ba69bfe-8f45-42a1-bd4e-9686e78932b3"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("8e8d9ee9-4eb9-4033-957e-63b03620f166"));

            migrationBuilder.RenameColumn(
                name: "BusinessUnitId",
                table: "Mobilites",
                newName: "CountryId");

            migrationBuilder.AddColumn<Guid>(
                name: "ContryId",
                table: "Mobilites",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("297a2d46-b65a-4441-bc58-0915155a71bc"), "C# certified developer" },
                    { new Guid("b2fbe4de-c9e4-407c-8b95-55e756769e7f"), "High School Diploma" },
                    { new Guid("6cdc87ff-4018-4a07-8abc-078baed07251"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b16ada82-aa19-439f-b220-b84b83623c8f"), "dotNet" },
                    { new Guid("767e2772-ff38-46dc-b420-20a1e3d686cc"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bfad5383-bcac-4cb6-9a2a-a1610e97c73f"), "SelfTaught" },
                    { new Guid("1333f237-8a08-4d9a-bc7b-e2c06d105c6f"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new DateTime(2019, 8, 22, 10, 24, 25, 586, DateTimeKind.Local).AddTicks(5109), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8a1594fe-4997-48f9-aee4-c8b69629be2b"), "Français" },
                    { new Guid("38bcb276-0e8a-4bf4-a22d-dbd77874e0c5"), "Néerlandais" },
                    { new Guid("007d9271-0a35-4fef-8efe-7be4070a2b6f"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new Guid("8a1594fe-4997-48f9-aee4-c8b69629be2b"), 5, true },
                    { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new Guid("8a1594fe-4997-48f9-aee4-c8b69629be2b"), 5, true },
                    { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new Guid("38bcb276-0e8a-4bf4-a22d-dbd77874e0c5"), 2, true },
                    { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new Guid("38bcb276-0e8a-4bf4-a22d-dbd77874e0c5"), 1, true },
                    { new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new Guid("007d9271-0a35-4fef-8efe-7be4070a2b6f"), 4, true },
                    { new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new Guid("007d9271-0a35-4fef-8efe-7be4070a2b6f"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("297a2d46-b65a-4441-bc58-0915155a71bc"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cdc87ff-4018-4a07-8abc-078baed07251"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2fbe4de-c9e4-407c-8b95-55e756769e7f"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cdc87ff-4018-4a07-8abc-078baed07251"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("b16ada82-aa19-439f-b220-b84b83623c8f"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), true, 4 },
                    { new Guid("767e2772-ff38-46dc-b420-20a1e3d686cc"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), true, 2 },
                    { new Guid("b16ada82-aa19-439f-b220-b84b83623c8f"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), true, 4 },
                    { new Guid("767e2772-ff38-46dc-b420-20a1e3d686cc"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("bfad5383-bcac-4cb6-9a2a-a1610e97c73f"), new Guid("306ad9e5-abc1-4af8-b1db-4410f21d440f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1333f237-8a08-4d9a-bc7b-e2c06d105c6f"), new Guid("1eb8255d-26e0-469c-8fce-9d0b531ecd13"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobilites_ContryId",
                table: "Mobilites",
                column: "ContryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobilites_Countries_ContryId",
                table: "Mobilites",
                column: "ContryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
