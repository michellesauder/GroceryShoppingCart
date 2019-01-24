using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryShoppingCart.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                });

            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    FruitId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.FruitId);
                });

            migrationBuilder.CreateTable(
                name: "Grain",
                columns: table => new
                {
                    GrainId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grain", x => x.GrainId);
                });

            migrationBuilder.CreateTable(
                name: "Meat",
                columns: table => new
                {
                    MeatId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meat", x => x.MeatId);
                });

            migrationBuilder.CreateTable(
                name: "Vegetables",
                columns: table => new
                {
                    VegetableId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetables", x => x.VegetableId);
                });

            migrationBuilder.CreateTable(
                name: "GroceryCart",
                columns: table => new
                {
                    DrinkId = table.Column<int>(nullable: false),
                    FruitId = table.Column<int>(nullable: false),
                    GrainId = table.Column<int>(nullable: false),
                    MeatId = table.Column<int>(nullable: false),
                    VegetableId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroceryCart", x => new { x.DrinkId, x.MeatId, x.VegetableId, x.FruitId, x.GrainId });
                    table.UniqueConstraint("AK_GroceryCart_DrinkId_FruitId_GrainId_MeatId_VegetableId", x => new { x.DrinkId, x.FruitId, x.GrainId, x.MeatId, x.VegetableId });
                    table.ForeignKey(
                        name: "FK_GroceryCart_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "DrinkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroceryCart_Fruits_FruitId",
                        column: x => x.FruitId,
                        principalTable: "Fruits",
                        principalColumn: "FruitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroceryCart_Grain_GrainId",
                        column: x => x.GrainId,
                        principalTable: "Grain",
                        principalColumn: "GrainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroceryCart_Meat_MeatId",
                        column: x => x.MeatId,
                        principalTable: "Meat",
                        principalColumn: "MeatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroceryCart_Vegetables_VegetableId",
                        column: x => x.VegetableId,
                        principalTable: "Vegetables",
                        principalColumn: "VegetableId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroceryCart_FruitId",
                table: "GroceryCart",
                column: "FruitId");

            migrationBuilder.CreateIndex(
                name: "IX_GroceryCart_GrainId",
                table: "GroceryCart",
                column: "GrainId");

            migrationBuilder.CreateIndex(
                name: "IX_GroceryCart_MeatId",
                table: "GroceryCart",
                column: "MeatId");

            migrationBuilder.CreateIndex(
                name: "IX_GroceryCart_VegetableId",
                table: "GroceryCart",
                column: "VegetableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroceryCart");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Fruits");

            migrationBuilder.DropTable(
                name: "Grain");

            migrationBuilder.DropTable(
                name: "Meat");

            migrationBuilder.DropTable(
                name: "Vegetables");
        }
    }
}
