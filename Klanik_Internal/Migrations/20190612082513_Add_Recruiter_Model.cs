using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class Add_Recruiter_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("76ff0398-028c-438c-8ad1-9584f0972522"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"));

            migrationBuilder.AddColumn<Guid>(
                name: "RecruiterId",
                table: "Konsultant",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recruiter",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recruiter_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Konsultant_RecruiterId",
                table: "Konsultant",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Recruiter_ContactId",
                table: "Recruiter",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Konsultant_Recruiter_RecruiterId",
                table: "Konsultant",
                column: "RecruiterId",
                principalTable: "Recruiter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Konsultant_Recruiter_RecruiterId",
                table: "Konsultant");

            migrationBuilder.DropTable(
                name: "Recruiter");

            migrationBuilder.DropIndex(
                name: "IX_Konsultant_RecruiterId",
                table: "Konsultant");

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

            migrationBuilder.DropColumn(
                name: "RecruiterId",
                table: "Konsultant");

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"), "C# certified developer" },
                    { new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"), "High School Diploma" },
                    { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), "dotNet" },
                    { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"), "SelfTaught" },
                    { new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2019, 6, 11, 15, 8, 30, 555, DateTimeKind.Local).AddTicks(2842), "FullStack .Net Developer", "Michel", "Gouzee" },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"), "Français" },
                    { new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"), "Néerlandais" },
                    { new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"), 5, true },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("65a5db6c-e082-4e79-ba71-576b0375ca80"), 5, true },
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"), 2, true },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("c8dc271a-5a21-4105-9032-c094b3e1e63b"), 1, true },
                    { new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"), 4, true },
                    { new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new Guid("e314aace-bfcf-41c8-a9b2-5e1c4f47ec4d"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("cfeba99f-fc12-4dc8-b9cb-017c85060867"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2071f83a-7788-420d-9908-5f6f0a77fc01"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76ff0398-028c-438c-8ad1-9584f0972522"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), true, 4 },
                    { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), true, 2 },
                    { new Guid("053c93d9-f701-49ef-ae46-4fc1c2ce73cf"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), true, 4 },
                    { new Guid("24da4fda-0abc-44e7-bb28-4598545d2cf8"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("320d035c-5f9d-4f6c-bcf9-f4e605e45737"), new Guid("6dbb09cb-e50b-4ce0-b976-85ca470ba2f4"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76c363d4-c0d2-4866-ab4f-2160d3c5b8ef"), new Guid("bc9ab653-be7e-42f0-a0b4-1744951de053"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
