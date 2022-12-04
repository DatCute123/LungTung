using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Codefirst_17328.Migrations
{
    public partial class thanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Humans",
                columns: table => new
                {
                    CMT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tuoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    SoDT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humans", x => x.CMT);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiongCho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    HumanCMT = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dogs_Humans_HumanCMT",
                        column: x => x.HumanCMT,
                        principalTable: "Humans",
                        principalColumn: "CMT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_HumanCMT",
                table: "Dogs",
                column: "HumanCMT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Humans");
        }
    }
}
