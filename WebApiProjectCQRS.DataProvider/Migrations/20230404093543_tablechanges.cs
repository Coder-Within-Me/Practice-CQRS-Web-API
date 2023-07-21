using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProjectCQRS.DataProvider.Migrations
{
    /// <inheritdoc />
    public partial class tablechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ContactNumber",
                table: "EmployeeDetails",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContactNumber",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
