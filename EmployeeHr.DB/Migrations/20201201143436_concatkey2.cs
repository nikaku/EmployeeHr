using Microsoft.EntityFrameworkCore.Migrations;

namespace Hr.DB.Migrations
{
    public partial class concatkey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PositionsAndDepartments_BranchId",
                table: "PositionsAndDepartments");

            migrationBuilder.CreateIndex(
                name: "IX_PositionsAndDepartments_BranchId_DepartmentId_PositionId",
                table: "PositionsAndDepartments",
                columns: new[] { "BranchId", "DepartmentId", "PositionId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PositionsAndDepartments_BranchId_DepartmentId_PositionId",
                table: "PositionsAndDepartments");

            migrationBuilder.CreateIndex(
                name: "IX_PositionsAndDepartments_BranchId",
                table: "PositionsAndDepartments",
                column: "BranchId");
        }
    }
}
