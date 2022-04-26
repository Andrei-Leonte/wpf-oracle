using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacultyStudents.Infrastructure.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materii",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NUME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NIVEL = table.Column<short>(type: "NUMBER(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materii", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Specializari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NUME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializari", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpecializareMaterii",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MaterieId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SpecializareId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializareMaterii", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SpecializareMaterii_Materii_MaterieId",
                        column: x => x.MaterieId,
                        principalTable: "Materii",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecializareMaterii_Specializari_SpecializareId",
                        column: x => x.SpecializareId,
                        principalTable: "Specializari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "STUDENTI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    SPECIALIZAREID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PRENUME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TELEFON = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENTI", x => x.ID);
                    table.ForeignKey(
                        name: "FK_STUDENTI_Specializari_SPECIALIZAREID",
                        column: x => x.SPECIALIZAREID,
                        principalTable: "Specializari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NIVEL = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    MATERIAID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    STUDENTID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Note_Materii_MATERIAID",
                        column: x => x.MATERIAID,
                        principalTable: "Materii",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Note_STUDENTI_STUDENTID",
                        column: x => x.STUDENTID,
                        principalTable: "STUDENTI",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Note_MATERIAID",
                table: "Note",
                column: "MATERIAID");

            migrationBuilder.CreateIndex(
                name: "IX_Note_STUDENTID",
                table: "Note",
                column: "STUDENTID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializareMaterii_MaterieId",
                table: "SpecializareMaterii",
                column: "MaterieId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializareMaterii_SpecializareId",
                table: "SpecializareMaterii",
                column: "SpecializareId");

            migrationBuilder.CreateIndex(
                name: "IX_STUDENTI_SPECIALIZAREID",
                table: "STUDENTI",
                column: "SPECIALIZAREID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "SpecializareMaterii");

            migrationBuilder.DropTable(
                name: "STUDENTI");

            migrationBuilder.DropTable(
                name: "Materii");

            migrationBuilder.DropTable(
                name: "Specializari");
        }
    }
}
