using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeHr.DB.Migrations
{
    public partial class basePosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasePositionStaffEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionsAndDepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePositionStaffEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePositionStaffEntities_PositionsAndDepartments_PositionsAndDepartmentsId",
                        column: x => x.PositionsAndDepartmentsId,
                        principalTable: "PositionsAndDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasePositionStaffEntities_PositionsAndDepartmentsId",
                table: "BasePositionStaffEntities",
                column: "PositionsAndDepartmentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasePositionStaffEntities");
        }
    }
}
