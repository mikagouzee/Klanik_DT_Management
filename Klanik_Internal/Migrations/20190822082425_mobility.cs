using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class mobility : Migration
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

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mobilites",
                columns: table => new
                {
                    KonsultantId = table.Column<Guid>(nullable: false),
                    CountryId = table.Column<Guid>(nullable: false),
                    ContryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobilites", x => new { x.KonsultantId, x.CountryId });
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mobilites");

            migrationBuilder.DropTable(
                name: "Countries");

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
