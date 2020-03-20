using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyCL.Migrations
{
    public partial class AnotherOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Medicines");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Medicines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_CompanyId",
                table: "Medicines",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Companies_CompanyId",
                table: "Medicines",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Companies_CompanyId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_CompanyId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Medicines");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
