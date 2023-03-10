using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class bien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Biens_BiensId",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "BienId",
                table: "Intervention");

            migrationBuilder.AlterColumn<int>(
                name: "BiensId",
                table: "Intervention",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Biens_BiensId",
                table: "Intervention",
                column: "BiensId",
                principalTable: "Biens",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Biens_BiensId",
                table: "Intervention");

            migrationBuilder.AlterColumn<int>(
                name: "BiensId",
                table: "Intervention",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "BienId",
                table: "Intervention",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Biens_BiensId",
                table: "Intervention",
                column: "BiensId",
                principalTable: "Biens",
                principalColumn: "BiensId");
        }
    }
}
