using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnBienBiensId",
                table: "Prets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnBienBiensId",
                table: "Intervention",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnBienBiensId",
                table: "Contrats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prets_UnBienBiensId",
                table: "Prets",
                column: "UnBienBiensId");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_UnBienBiensId",
                table: "Intervention",
                column: "UnBienBiensId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_UnBienBiensId",
                table: "Contrats",
                column: "UnBienBiensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Biens_UnBienBiensId",
                table: "Contrats",
                column: "UnBienBiensId",
                principalTable: "Biens",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Biens_UnBienBiensId",
                table: "Intervention",
                column: "UnBienBiensId",
                principalTable: "Biens",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prets_Biens_UnBienBiensId",
                table: "Prets",
                column: "UnBienBiensId",
                principalTable: "Biens",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Biens_UnBienBiensId",
                table: "Contrats");

            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Biens_UnBienBiensId",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Prets_Biens_UnBienBiensId",
                table: "Prets");

            migrationBuilder.DropIndex(
                name: "IX_Prets_UnBienBiensId",
                table: "Prets");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_UnBienBiensId",
                table: "Intervention");

            migrationBuilder.DropIndex(
                name: "IX_Contrats_UnBienBiensId",
                table: "Contrats");

            migrationBuilder.DropColumn(
                name: "UnBienBiensId",
                table: "Prets");

            migrationBuilder.DropColumn(
                name: "UnBienBiensId",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "UnBienBiensId",
                table: "Contrats");
        }
    }
}
