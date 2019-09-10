using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class bu_countries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
