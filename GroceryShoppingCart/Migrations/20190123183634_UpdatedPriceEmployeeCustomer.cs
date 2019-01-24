using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryShoppingCart.Migrations
{
    public partial class UpdatedPriceEmployeeCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_GroceryCart_DrinkId_FruitId_GrainId_MeatId_VegetableId",
                table: "GroceryCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroceryCart",
                table: "GroceryCart");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Vegetables",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Meat",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "GroceryCart",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "GroceryCart",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Grain",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Fruits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Drinks",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_GroceryCart_CustomerId_DrinkId_EmployeeId_FruitId_GrainId_MeatId_VegetableId",
                table: "GroceryCart",
                columns: new[] { "CustomerId", "DrinkId", "EmployeeId", "FruitId", "GrainId", "MeatId", "VegetableId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroceryCart",
                table: "GroceryCart",
                columns: new[] { "DrinkId", "MeatId", "VegetableId", "FruitId", "GrainId", "EmployeeId", "CustomerId" });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Branch = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroceryCart_EmployeeId",
                table: "GroceryCart",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroceryCart_Customer_CustomerId",
                table: "GroceryCart",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroceryCart_Employee_EmployeeId",
                table: "GroceryCart",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroceryCart_Customer_CustomerId",
                table: "GroceryCart");

            migrationBuilder.DropForeignKey(
                name: "FK_GroceryCart_Employee_EmployeeId",
                table: "GroceryCart");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_GroceryCart_CustomerId_DrinkId_EmployeeId_FruitId_GrainId_MeatId_VegetableId",
                table: "GroceryCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroceryCart",
                table: "GroceryCart");

            migrationBuilder.DropIndex(
                name: "IX_GroceryCart_EmployeeId",
                table: "GroceryCart");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Vegetables");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "GroceryCart");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "GroceryCart");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Grain");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Drinks");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_GroceryCart_DrinkId_FruitId_GrainId_MeatId_VegetableId",
                table: "GroceryCart",
                columns: new[] { "DrinkId", "FruitId", "GrainId", "MeatId", "VegetableId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroceryCart",
                table: "GroceryCart",
                columns: new[] { "DrinkId", "MeatId", "VegetableId", "FruitId", "GrainId" });
        }
    }
}
