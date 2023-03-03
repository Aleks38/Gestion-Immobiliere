using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class vazy4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Biens_UnBienBiensId",
                table: "Intervention");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_UnBienBiensId",
                table: "Intervention");

            migrationBuilder.RenameColumn(
                name: "UnBienBiensId",
                table: "Intervention",
                newName: "BienId");

            migrationBuilder.AddColumn<int>(
                name: "BiensId",
                table: "Intervention",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_BiensId",
                table: "Intervention",
                column: "BiensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Biens_BiensId",
                table: "Intervention",
                column: "BiensId",
                principalTable: "Biens",
                principalColumn: "BiensId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Biens_BiensId",
                table: "Intervention");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_BiensId",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "BiensId",
                table: "Intervention");

            migrationBuilder.RenameColumn(
                name: "BienId",
                table: "Intervention",
                newName: "UnBienBiensId");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_UnBienBiensId",
                table: "Intervention",
                column: "UnBienBiensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Biens_UnBienBiensId",
                table: "Intervention",
                column: "UnBienBiensId",
                principalTable: "Biens",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
