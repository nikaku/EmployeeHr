using Microsoft.EntityFrameworkCore.Migrations;

namespace Hr.DB.Migrations
{
    public partial class changedJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PositionsAndDepartments_Departments_DepartmentId",
                table: "PositionsAndDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionsAndDepartments_DepartmentsAndBranches_DepartmentsAndBranchesId",
                table: "PositionsAndDepartments");

            migrationBuilder.RenameColumn(
                name: "DepartmentsAndBranchesId",
                table: "PositionsAndDepartments",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_PositionsAndDepartments_DepartmentsAndBranchesId",
                table: "PositionsAndDepartments",
                newName: "IX_PositionsAndDepartments_BranchId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "PositionsAndDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionsAndDepartments_Branches_BranchId",
                table: "PositionsAndDepartments",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionsAndDepartments_Departments_DepartmentId",
                table: "PositionsAndDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PositionsAndDepartments_Branches_BranchId",
                table: "PositionsAndDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionsAndDepartments_Departments_DepartmentId",
                table: "PositionsAndDepartments");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "PositionsAndDepartments",
                newName: "DepartmentsAndBranchesId");

            migrationBuilder.RenameIndex(
                name: "IX_PositionsAndDepartments_BranchId",
                table: "PositionsAndDepartments",
                newName: "IX_PositionsAndDepartments_DepartmentsAndBranchesId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "PositionsAndDepartments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PositionsAndDepartments_Departments_DepartmentId",
                table: "PositionsAndDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionsAndDepartments_DepartmentsAndBranches_DepartmentsAndBranchesId",
                table: "PositionsAndDepartments",
                column: "DepartmentsAndBranchesId",
                principalTable: "DepartmentsAndBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
