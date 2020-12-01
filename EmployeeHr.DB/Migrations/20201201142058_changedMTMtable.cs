using Microsoft.EntityFrameworkCore.Migrations;

namespace Hr.DB.Migrations
{
    public partial class changedMTMtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsAndBranches_Branches_BranchId",
                table: "DepartmentsAndBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsAndBranches_Departments_DepartmentId",
                table: "DepartmentsAndBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentsAndBranches",
                table: "DepartmentsAndBranches");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentsAndBranches_BranchId",
                table: "DepartmentsAndBranches");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DepartmentsAndBranches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentsAndBranches",
                table: "DepartmentsAndBranches",
                columns: new[] { "BranchId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsAndBranches_Branches_BranchId",
                table: "DepartmentsAndBranches",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsAndBranches_Departments_DepartmentId",
                table: "DepartmentsAndBranches",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsAndBranches_Branches_BranchId",
                table: "DepartmentsAndBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsAndBranches_Departments_DepartmentId",
                table: "DepartmentsAndBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentsAndBranches",
                table: "DepartmentsAndBranches");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DepartmentsAndBranches",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentsAndBranches",
                table: "DepartmentsAndBranches",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsAndBranches_BranchId",
                table: "DepartmentsAndBranches",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsAndBranches_Branches_BranchId",
                table: "DepartmentsAndBranches",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsAndBranches_Departments_DepartmentId",
                table: "DepartmentsAndBranches",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
