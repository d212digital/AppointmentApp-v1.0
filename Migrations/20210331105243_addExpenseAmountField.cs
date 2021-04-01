using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentApp.Migrations
{
    public partial class addExpenseAmountField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseAmount",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseAmount",
                table: "Items");
        }
    }
}
