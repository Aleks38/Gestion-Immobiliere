using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class new6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biens_Prets_PretId",
                table: "Biens");

            migrationBuilder.RenameColumn(
                name: "PretId",
                table: "Prets",
                newName: "PretsId");

            migrationBuilder.RenameColumn(
                name: "PretId",
                table: "Biens",
                newName: "PretsId");

            migrationBuilder.RenameIndex(
                name: "IX_Biens_PretId",
                table: "Biens",
                newName: "IX_Biens_PretsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biens_Prets_PretsId",
                table: "Biens",
                column: "PretsId",
                principalTable: "Prets",
                principalColumn: "PretsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biens_Prets_PretsId",
                table: "Biens");

            migrationBuilder.RenameColumn(
                name: "PretsId",
                table: "Prets",
                newName: "PretId");

            migrationBuilder.RenameColumn(
                name: "PretsId",
                table: "Biens",
                newName: "PretId");

            migrationBuilder.RenameIndex(
                name: "IX_Biens_PretsId",
                table: "Biens",
                newName: "IX_Biens_PretId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biens_Prets_PretId",
                table: "Biens",
                column: "PretId",
                principalTable: "Prets",
                principalColumn: "PretId");
        }
    }
}
