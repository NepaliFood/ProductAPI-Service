using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "ImageFile", "Name", "Price", "SpicyLevel" },
                values: new object[,]
                {
                    { 1, "Main", "Aromatic golden chicken pieces in an incredible curry sauce.", "https://freeimage.host/i/VNmlwu", "Butter Chicken", 18.0, "Mild" },
                    { 2, "Main", "A standard element of Goan cuisine derived from the Portuguese carne de vinha d'alhos (meat in garlic marinade).", "https://freeimage.host/i/VNmcue", "Vindaloo", 16.0, "High" },
                    { 3, "Curry", "An indian lamb curry with a heady combination of intense spices in a creamy tomato curry sauce.", "https://freeimage.host/i/VNma99", "Lamb Roghanjosh", 18.0, "Medium" },
                    { 4, "Main", "A rich & creamy curry made with paneer, spices, onions, tomatoes, cashews and butter.", "https://freeimage.host/i/VNm787", "Paneer Butter Masala", 18.0, "Mild" },
                    { 5, "Dessert", "A madras curry is a fairly hot curry with a dark red thick sauce (the colour comes from the chillies and paprika).", "https://freeimage.host/i/VNm0Zb", "Chicken Madras", 18.0, "Mild" },
                    { 6, "Starter", "A dumpling made of all-purpose flour and filled with either meat or vegetables.", "https://freeimage.host/i/VNmEnj", "Nepalese Momo", 10.0, "Medium" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);
        }
    }
}
