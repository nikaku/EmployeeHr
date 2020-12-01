using Microsoft.EntityFrameworkCore.Migrations;

namespace Hr.DB.Migrations
{
    public partial class changedFksNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Branches_BranchId",
                table: "BankAccounts");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "BankAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Branches_BranchId",
                table: "BankAccounts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Branches_BranchId",
                table: "BankAccounts");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "BankAccounts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Branches_BranchId",
                table: "BankAccounts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
