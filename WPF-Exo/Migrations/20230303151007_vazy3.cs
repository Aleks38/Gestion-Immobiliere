using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class vazy3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PretId",
                table: "Biens",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Biens_PretId",
                table: "Biens",
                column: "PretId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biens_Prets_PretId",
                table: "Biens",
                column: "PretId",
                principalTable: "Prets",
                principalColumn: "PretId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biens_Prets_PretId",
                table: "Biens");

            migrationBuilder.DropIndex(
                name: "IX_Biens_PretId",
                table: "Biens");

            migrationBuilder.DropColumn(
                name: "PretId",
                table: "Biens");
        }
    }
}
