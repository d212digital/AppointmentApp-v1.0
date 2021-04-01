using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentApp.Migrations
{
    public partial class addExpenseCodeAndExpenseNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseCode",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ExpenseName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ExpenseName",
                table: "Items");
        }
    }
}
