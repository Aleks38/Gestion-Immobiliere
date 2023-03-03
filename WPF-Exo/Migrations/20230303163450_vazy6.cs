using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_Exo.Migrations
{
    public partial class vazy6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Prestataires_PrestataireId",
                table: "Intervention");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_PrestataireId",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "PrestataireId",
                table: "Intervention");

            migrationBuilder.CreateTable(
                name: "InterventionPrestataire",
                columns: table => new
                {
                    ListInterventionInterventionId = table.Column<int>(type: "integer", nullable: false),
                    ListPrestaPrestataireId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionPrestataire", x => new { x.ListInterventionInterventionId, x.ListPrestaPrestataireId });
                    table.ForeignKey(
                        name: "FK_InterventionPrestataire_Intervention_ListInterventionInterv~",
                        column: x => x.ListInterventionInterventionId,
                        principalTable: "Intervention",
                        principalColumn: "InterventionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterventionPrestataire_Prestataires_ListPrestaPrestataireId",
                        column: x => x.ListPrestaPrestataireId,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterventionPrestataire_ListPrestaPrestataireId",
                table: "InterventionPrestataire",
                column: "ListPrestaPrestataireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterventionPrestataire");

            migrationBuilder.AddColumn<int>(
                name: "PrestataireId",
                table: "Intervention",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_PrestataireId",
                table: "Intervention",
                column: "PrestataireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Prestataires_PrestataireId",
                table: "Intervention",
                column: "PrestataireId",
                principalTable: "Prestataires",
                principalColumn: "PrestataireId");
        }
    }
}
