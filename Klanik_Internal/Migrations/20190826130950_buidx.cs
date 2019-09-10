using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class buidx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new Guid("09e70132-3d59-45d7-82f6-c643389c8ab7") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new Guid("2f568f4e-4308-475d-9fd4-64c7f3e7610d") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new Guid("c4717482-a5bb-4d89-9fae-0b30be4e1ae1") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new Guid("09e70132-3d59-45d7-82f6-c643389c8ab7") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new Guid("2f568f4e-4308-475d-9fd4-64c7f3e7610d") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new Guid("c4717482-a5bb-4d89-9fae-0b30be4e1ae1") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("33996846-f6a1-4b07-abd4-5e11baf8aa73"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5de37c1e-0222-4f80-8ec2-be4238c2a52d"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("5de37c1e-0222-4f80-8ec2-be4238c2a52d"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("9bef2f44-8fc9-40d9-a86e-d9c29b34fd33"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("6afbc5a2-792a-4e1e-9241-9a6479acc50f"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("6afbc5a2-792a-4e1e-9241-9a6479acc50f"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("e2f8a2fc-0a32-4e81-b38d-08e4ec2a54ee"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("e2f8a2fc-0a32-4e81-b38d-08e4ec2a54ee"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("6e48386e-ab81-4ef5-8325-d4af870af80e"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("ea96b3c5-9a90-4ce9-8e06-94685e338075"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("33996846-f6a1-4b07-abd4-5e11baf8aa73"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("5de37c1e-0222-4f80-8ec2-be4238c2a52d"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("9bef2f44-8fc9-40d9-a86e-d9c29b34fd33"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("6afbc5a2-792a-4e1e-9241-9a6479acc50f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("e2f8a2fc-0a32-4e81-b38d-08e4ec2a54ee"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("6e48386e-ab81-4ef5-8325-d4af870af80e"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("ea96b3c5-9a90-4ce9-8e06-94685e338075"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("09e70132-3d59-45d7-82f6-c643389c8ab7"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("2f568f4e-4308-475d-9fd4-64c7f3e7610d"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("c4717482-a5bb-4d89-9fae-0b30be4e1ae1"));

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04d8a0f5-7e7d-47ba-a4c0-b71659ba5bda"), "C# certified developer" },
                    { new Guid("3bb1ea83-7f17-4dfa-b511-42ae12653b5e"), "High School Diploma" },
                    { new Guid("8cb8cddb-8826-45a0-908b-2eb552c67f38"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03861879-984d-4edd-a946-821d8d44d90f"), "dotNet" },
                    { new Guid("d9be8918-0c69-4a42-9b17-98cbd3ab4966"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e412143c-2d77-4792-83c6-fa0723da6ca8"), "SelfTaught" },
                    { new Guid("757269cd-5d65-4c64-8090-ce69796266ca"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new DateTime(2019, 8, 26, 15, 9, 49, 976, DateTimeKind.Local).AddTicks(4986), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("720fe4ce-17f5-4714-aa3c-c1bd704ab2a9"), "Français" },
                    { new Guid("00f1e9b5-1a7e-4382-a066-b0ca4cfaf6b1"), "Néerlandais" },
                    { new Guid("6145bcce-5d6f-4d1c-8644-b025d880a676"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new Guid("720fe4ce-17f5-4714-aa3c-c1bd704ab2a9"), 5, true },
                    { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new Guid("720fe4ce-17f5-4714-aa3c-c1bd704ab2a9"), 5, true },
                    { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new Guid("00f1e9b5-1a7e-4382-a066-b0ca4cfaf6b1"), 2, true },
                    { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new Guid("00f1e9b5-1a7e-4382-a066-b0ca4cfaf6b1"), 1, true },
                    { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new Guid("6145bcce-5d6f-4d1c-8644-b025d880a676"), 4, true },
                    { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new Guid("6145bcce-5d6f-4d1c-8644-b025d880a676"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("04d8a0f5-7e7d-47ba-a4c0-b71659ba5bda"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cb8cddb-8826-45a0-908b-2eb552c67f38"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bb1ea83-7f17-4dfa-b511-42ae12653b5e"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cb8cddb-8826-45a0-908b-2eb552c67f38"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("03861879-984d-4edd-a946-821d8d44d90f"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), true, 4 },
                    { new Guid("d9be8918-0c69-4a42-9b17-98cbd3ab4966"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), true, 2 },
                    { new Guid("03861879-984d-4edd-a946-821d8d44d90f"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), true, 4 },
                    { new Guid("d9be8918-0c69-4a42-9b17-98cbd3ab4966"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("e412143c-2d77-4792-83c6-fa0723da6ca8"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("757269cd-5d65-4c64-8090-ce69796266ca"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobilites_KonsultantId_BusinessUnitId",
                table: "Mobilites",
                columns: new[] { "KonsultantId", "BusinessUnitId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mobilites_KonsultantId_BusinessUnitId",
                table: "Mobilites");

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new Guid("00f1e9b5-1a7e-4382-a066-b0ca4cfaf6b1") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new Guid("6145bcce-5d6f-4d1c-8644-b025d880a676") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"), new Guid("720fe4ce-17f5-4714-aa3c-c1bd704ab2a9") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new Guid("00f1e9b5-1a7e-4382-a066-b0ca4cfaf6b1") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new Guid("6145bcce-5d6f-4d1c-8644-b025d880a676") });

            migrationBuilder.DeleteData(
                table: "KnownLanguage",
                keyColumns: new[] { "KonsultantId", "LanguageId" },
                keyValues: new object[] { new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"), new Guid("720fe4ce-17f5-4714-aa3c-c1bd704ab2a9") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("04d8a0f5-7e7d-47ba-a4c0-b71659ba5bda"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("3bb1ea83-7f17-4dfa-b511-42ae12653b5e"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("8cb8cddb-8826-45a0-908b-2eb552c67f38"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480") });

            migrationBuilder.DeleteData(
                table: "Owned Certificate",
                keyColumns: new[] { "CertificateId", "KonsultantId" },
                keyValues: new object[] { new Guid("8cb8cddb-8826-45a0-908b-2eb552c67f38"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("03861879-984d-4edd-a946-821d8d44d90f"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("03861879-984d-4edd-a946-821d8d44d90f"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("d9be8918-0c69-4a42-9b17-98cbd3ab4966"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480") });

            migrationBuilder.DeleteData(
                table: "OwnedCompetence",
                keyColumns: new[] { "CompetenceId", "KonsultantId" },
                keyValues: new object[] { new Guid("d9be8918-0c69-4a42-9b17-98cbd3ab4966"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("757269cd-5d65-4c64-8090-ce69796266ca"), new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480") });

            migrationBuilder.DeleteData(
                table: "PersonalEducation",
                keyColumns: new[] { "EducationId", "KonsultantId" },
                keyValues: new object[] { new Guid("e412143c-2d77-4792-83c6-fa0723da6ca8"), new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04") });

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("04d8a0f5-7e7d-47ba-a4c0-b71659ba5bda"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("3bb1ea83-7f17-4dfa-b511-42ae12653b5e"));

            migrationBuilder.DeleteData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: new Guid("8cb8cddb-8826-45a0-908b-2eb552c67f38"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("03861879-984d-4edd-a946-821d8d44d90f"));

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: new Guid("d9be8918-0c69-4a42-9b17-98cbd3ab4966"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("757269cd-5d65-4c64-8090-ce69796266ca"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("e412143c-2d77-4792-83c6-fa0723da6ca8"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("5ff16537-4bd0-46a9-bc05-897ca45c8480"));

            migrationBuilder.DeleteData(
                table: "Konsultant",
                keyColumn: "Id",
                keyValue: new Guid("fe19abe2-8970-451b-a016-c5d70fb83d04"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("00f1e9b5-1a7e-4382-a066-b0ca4cfaf6b1"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("6145bcce-5d6f-4d1c-8644-b025d880a676"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("720fe4ce-17f5-4714-aa3c-c1bd704ab2a9"));

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9bef2f44-8fc9-40d9-a86e-d9c29b34fd33"), "C# certified developer" },
                    { new Guid("33996846-f6a1-4b07-abd4-5e11baf8aa73"), "High School Diploma" },
                    { new Guid("5de37c1e-0222-4f80-8ec2-be4238c2a52d"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e2f8a2fc-0a32-4e81-b38d-08e4ec2a54ee"), "dotNet" },
                    { new Guid("6afbc5a2-792a-4e1e-9241-9a6479acc50f"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ea96b3c5-9a90-4ce9-8e06-94685e338075"), "SelfTaught" },
                    { new Guid("6e48386e-ab81-4ef5-8325-d4af870af80e"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "RecruiterId", "Surname" },
                values: new object[,]
                {
                    { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new DateTime(2019, 8, 23, 9, 3, 20, 830, DateTimeKind.Local).AddTicks(5429), "FullStack .Net Developer", "Michel", null, "Gouzee" },
                    { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", null, "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2f568f4e-4308-475d-9fd4-64c7f3e7610d"), "Français" },
                    { new Guid("c4717482-a5bb-4d89-9fae-0b30be4e1ae1"), "Néerlandais" },
                    { new Guid("09e70132-3d59-45d7-82f6-c643389c8ab7"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new Guid("2f568f4e-4308-475d-9fd4-64c7f3e7610d"), 5, true },
                    { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new Guid("2f568f4e-4308-475d-9fd4-64c7f3e7610d"), 5, true },
                    { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new Guid("c4717482-a5bb-4d89-9fae-0b30be4e1ae1"), 2, true },
                    { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new Guid("c4717482-a5bb-4d89-9fae-0b30be4e1ae1"), 1, true },
                    { new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new Guid("09e70132-3d59-45d7-82f6-c643389c8ab7"), 4, true },
                    { new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new Guid("09e70132-3d59-45d7-82f6-c643389c8ab7"), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("9bef2f44-8fc9-40d9-a86e-d9c29b34fd33"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5de37c1e-0222-4f80-8ec2-be4238c2a52d"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33996846-f6a1-4b07-abd4-5e11baf8aa73"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5de37c1e-0222-4f80-8ec2-be4238c2a52d"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("e2f8a2fc-0a32-4e81-b38d-08e4ec2a54ee"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), true, 4 },
                    { new Guid("6afbc5a2-792a-4e1e-9241-9a6479acc50f"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), true, 2 },
                    { new Guid("e2f8a2fc-0a32-4e81-b38d-08e4ec2a54ee"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), true, 4 },
                    { new Guid("6afbc5a2-792a-4e1e-9241-9a6479acc50f"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), true, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("ea96b3c5-9a90-4ce9-8e06-94685e338075"), new Guid("c299cc6e-89f9-4d49-ac7d-69d6740a3211"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e48386e-ab81-4ef5-8325-d4af870af80e"), new Guid("bddfb45b-96ad-4d4f-9aa8-1a86376ff633"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
