using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyCL.Migrations
{
    public partial class ThisMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Prescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "Prescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PharmacyId",
                table: "Prescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PharmacyId",
                table: "Medicines",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PrescriptionId",
                table: "Users",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_LocationId",
                table: "Prescriptions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicineId",
                table: "Prescriptions",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PharmacyId",
                table: "Prescriptions",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_PharmacyId",
                table: "Medicines",
                column: "PharmacyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Pharmacies_PharmacyId",
                table: "Medicines",
                column: "PharmacyId",
                principalTable: "Pharmacies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_PharmacyBranches_LocationId",
                table: "Prescriptions",
                column: "LocationId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Medicines_MedicineId",
                table: "Prescriptions",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Pharmacies_PharmacyId",
                table: "Prescriptions",
                column: "PharmacyId",
                principalTable: "Pharmacies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Prescriptions_PrescriptionId",
                table: "Users",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Pharmacies_PharmacyId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_PharmacyBranches_LocationId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Medicines_MedicineId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Pharmacies_PharmacyId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Prescriptions_PrescriptionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PrescriptionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_LocationId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_MedicineId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_PharmacyId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_PharmacyId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PharmacyId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PharmacyId",
                table: "Medicines");
        }
    }
}
