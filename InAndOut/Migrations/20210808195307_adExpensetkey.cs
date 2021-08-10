using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class adExpensetkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseTypeId",
                table: "Expense",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseTypeId",
                table: "Expense",
                column: "ExpenseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpenseType_ExpenseTypeId",
                table: "Expense",
                column: "ExpenseTypeId",
                principalTable: "ExpenseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpenseType_ExpenseTypeId",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_ExpenseTypeId",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeId",
                table: "Expense");
        }
    }
}
