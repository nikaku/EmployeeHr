using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeHr.DB.Migrations
{
    public partial class addedNameToMunicipality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settlements_Municipalities_MunicipalityId",
                table: "Settlements");

            migrationBuilder.AlterColumn<int>(
                name: "MunicipalityId",
                table: "Settlements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Municipalities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Settlements_Municipalities_MunicipalityId",
                table: "Settlements",
                column: "MunicipalityId",
                principalTable: "Municipalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settlements_Municipalities_MunicipalityId",
                table: "Settlements");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Municipalities");

            migrationBuilder.AlterColumn<int>(
                name: "MunicipalityId",
                table: "Settlements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Settlements_Municipalities_MunicipalityId",
                table: "Settlements",
                column: "MunicipalityId",
                principalTable: "Municipalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
