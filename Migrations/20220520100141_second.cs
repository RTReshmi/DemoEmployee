using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEmployee.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ge",
                table: "Employee",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employee",
                newName: "ge");
        }
    }
}
