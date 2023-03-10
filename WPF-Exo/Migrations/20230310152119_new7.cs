using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class new7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biens_Prets_PretsId",
                table: "Biens");

            migrationBuilder.DropTable(
                name: "Prets");

            migrationBuilder.RenameColumn(
                name: "PretsId",
                table: "Biens",
                newName: "PretId");

            migrationBuilder.RenameIndex(
                name: "IX_Biens_PretsId",
                table: "Biens",
                newName: "IX_Biens_PretId");

            migrationBuilder.CreateTable(
                name: "Pret",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Apport = table.Column<int>(type: "integer", nullable: false),
                    Mensualite = table.Column<int>(type: "integer", nullable: false),
                    Duree = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pret", x => x.PretId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Biens_Pret_PretId",
                table: "Biens",
                column: "PretId",
                principalTable: "Pret",
                principalColumn: "PretId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biens_Pret_PretId",
                table: "Biens");

            migrationBuilder.DropTable(
                name: "Pret");

            migrationBuilder.RenameColumn(
                name: "PretId",
                table: "Biens",
                newName: "PretsId");

            migrationBuilder.RenameIndex(
                name: "IX_Biens_PretId",
                table: "Biens",
                newName: "IX_Biens_PretsId");

            migrationBuilder.CreateTable(
                name: "Prets",
                columns: table => new
                {
                    PretsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Apport = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Duree = table.Column<int>(type: "integer", nullable: false),
                    Mensualite = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prets", x => x.PretsId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Biens_Prets_PretsId",
                table: "Biens",
                column: "PretsId",
                principalTable: "Prets",
                principalColumn: "PretsId");
        }
    }
}
