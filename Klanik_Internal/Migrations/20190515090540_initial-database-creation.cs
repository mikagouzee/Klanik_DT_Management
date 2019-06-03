using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klanik_Internal.Migrations
{
    public partial class initialdatabasecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Konsultant",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Function = table.Column<string>(nullable: true),
                    Availability = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konsultant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owned Certificate",
                columns: table => new
                {
                    CertificateId = table.Column<Guid>(nullable: false),
                    KonsultantId = table.Column<Guid>(nullable: false),
                    Obtension = table.Column<DateTime>(nullable: false),
                    EndOfValidity = table.Column<DateTime>(nullable: true),
                    IsRelevant = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owned Certificate", x => new { x.CertificateId, x.KonsultantId });
                    table.ForeignKey(
                        name: "FK_Owned Certificate_Certificate_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owned Certificate_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnedCompetence",
                columns: table => new
                {
                    CompetenceId = table.Column<Guid>(nullable: false),
                    KonsultantId = table.Column<Guid>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedCompetence", x => new { x.CompetenceId, x.KonsultantId });
                    table.ForeignKey(
                        name: "FK_OwnedCompetence_Competence_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnedCompetence_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalEducation",
                columns: table => new
                {
                    EducationId = table.Column<Guid>(nullable: false),
                    KonsultantId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalEducation", x => new { x.EducationId, x.KonsultantId });
                    table.ForeignKey(
                        name: "FK_PersonalEducation_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalEducation_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalExperience",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KonsultantId = table.Column<Guid>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Context = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalExperience_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalReference",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KonsultantId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Function = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalReference_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnownLanguage",
                columns: table => new
                {
                    LanguageId = table.Column<Guid>(nullable: false),
                    KonsultantId = table.Column<Guid>(nullable: false),
                    Fluency = table.Column<int>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownLanguage", x => new { x.KonsultantId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_KnownLanguage_Konsultant_KonsultantId",
                        column: x => x.KonsultantId,
                        principalTable: "Konsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnownLanguage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accomplishment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProfessionalExperienceId = table.Column<Guid>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accomplishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accomplishment_ProfessionalExperience_ProfessionalExperienceId",
                        column: x => x.ProfessionalExperienceId,
                        principalTable: "ProfessionalExperience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalEnvironment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProfessionalExperienceId = table.Column<Guid>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Option = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalEnvironment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalEnvironment_ProfessionalExperience_ProfessionalExperienceId",
                        column: x => x.ProfessionalExperienceId,
                        principalTable: "ProfessionalExperience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProfessionalReferenceId = table.Column<Guid>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_ProfessionalReference_ProfessionalReferenceId",
                        column: x => x.ProfessionalReferenceId,
                        principalTable: "ProfessionalReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("80ed29c6-5d20-455e-b7b0-0fbc8b2cd447"), "C# certified developer" },
                    { new Guid("de9de72f-3147-4002-974c-d01eeb071de2"), "High School Diploma" },
                    { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), "BadAss Dev" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), "dotNet" },
                    { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), "javascript" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("907003f6-5a7d-4461-831a-71437dcedc50"), "SelfTaught" },
                    { new Guid("d2a8ccbd-0089-483f-b1c8-ea4a005dab32"), "High School" }
                });

            migrationBuilder.InsertData(
                table: "Konsultant",
                columns: new[] { "Id", "Availability", "Function", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2019, 5, 15, 11, 5, 40, 180, DateTimeKind.Local).AddTicks(2034), "FullStack .Net Developer", "Michel", "Gouzee" },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullStack .Net Developer", "Barnabé", "Magos" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"), "Français" },
                    { new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"), "Néerlandais" },
                    { new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"), "Anglais" }
                });

            migrationBuilder.InsertData(
                table: "KnownLanguage",
                columns: new[] { "KonsultantId", "LanguageId", "Fluency", "IsRelevant" },
                values: new object[,]
                {
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"), 5, false },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("4a19e0f1-61de-4983-b659-3d137f84f1fb"), 5, false },
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"), 2, false },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("d1de9801-9b62-4246-8d0c-6d716572334c"), 1, false },
                    { new Guid("6670b486-f434-4328-a96f-334d482297c3"), new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"), 4, false },
                    { new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new Guid("a843d670-80ba-415e-8d65-aca385c2ea19"), 4, false }
                });

            migrationBuilder.InsertData(
                table: "Owned Certificate",
                columns: new[] { "CertificateId", "KonsultantId", "EndOfValidity", "IsRelevant", "Obtension" },
                values: new object[,]
                {
                    { new Guid("80ed29c6-5d20-455e-b7b0-0fbc8b2cd447"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de9de72f-3147-4002-974c-d01eeb071de2"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8bf3423-5c3f-46a3-bcff-4a48d5f388cb"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OwnedCompetence",
                columns: new[] { "CompetenceId", "KonsultantId", "IsRelevant", "Rating" },
                values: new object[,]
                {
                    { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), false, 4 },
                    { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), false, 2 },
                    { new Guid("d22768fe-3e98-417e-a96d-6b465645b883"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), false, 4 },
                    { new Guid("ac833b61-a902-4595-acea-cc30f4e69c9d"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), false, 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonalEducation",
                columns: new[] { "EducationId", "KonsultantId", "EndDate", "IsRelevant", "StartDate" },
                values: new object[,]
                {
                    { new Guid("907003f6-5a7d-4461-831a-71437dcedc50"), new Guid("6670b486-f434-4328-a96f-334d482297c3"), new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2a8ccbd-0089-483f-b1c8-ea4a005dab32"), new Guid("6538b495-c41a-4da5-8fab-2befea5ba02f"), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2011, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accomplishment_ProfessionalExperienceId",
                table: "Accomplishment",
                column: "ProfessionalExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ProfessionalReferenceId",
                table: "Contact",
                column: "ProfessionalReferenceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KnownLanguage_LanguageId",
                table: "KnownLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Owned Certificate_KonsultantId",
                table: "Owned Certificate",
                column: "KonsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCompetence_KonsultantId",
                table: "OwnedCompetence",
                column: "KonsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalEducation_KonsultantId",
                table: "PersonalEducation",
                column: "KonsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalExperience_KonsultantId",
                table: "ProfessionalExperience",
                column: "KonsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalReference_KonsultantId",
                table: "ProfessionalReference",
                column: "KonsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalEnvironment_ProfessionalExperienceId",
                table: "TechnicalEnvironment",
                column: "ProfessionalExperienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accomplishment");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "KnownLanguage");

            migrationBuilder.DropTable(
                name: "Owned Certificate");

            migrationBuilder.DropTable(
                name: "OwnedCompetence");

            migrationBuilder.DropTable(
                name: "PersonalEducation");

            migrationBuilder.DropTable(
                name: "TechnicalEnvironment");

            migrationBuilder.DropTable(
                name: "ProfessionalReference");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "ProfessionalExperience");

            migrationBuilder.DropTable(
                name: "Konsultant");
        }
    }
}
