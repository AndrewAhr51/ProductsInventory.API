using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsInventory.API.Migrations
{
    public partial class InitialProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(nullable: false),
                    productCode = table.Column<string>(nullable: false),
                    releaseDate = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    starRating = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    imageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "description", "imageUrl", "price", "productCode", "productName", "releaseDate", "starRating" },
                values: new object[,]
                {
                    { 1, "Leaf rake with 48-inch wooden handle.", "assets/images/leaf_rake.png", 19.95m, "GDN-0011", "Leaf Rake", "March 19, 2019", 3.2m },
                    { 2, "5 gallon capacity rolling garden cart", "assets/images/garden_cart.png", 32.99m, "GDN-0023", "Garden Cart", "March 28, 2019", 4.2m },
                    { 3, "Curved claw steel hammer", "assets/images/hammer.png", 8.99m, "TBX-0048", "Hammer", "May 21, 2019", 4.8m },
                    { 4, "5-inch steel blade hand saw", "assets/images/saw.png", 11.55m, "TBX-0022", "Saw", "May 15, 2019", 3.7m },
                    { 5, "tandard two-button video game controller", "assets/images/xbox-controller.png", 35.95m, "GMG-0042", "Video Game Controller", "October 15, 2018", 4.6m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
