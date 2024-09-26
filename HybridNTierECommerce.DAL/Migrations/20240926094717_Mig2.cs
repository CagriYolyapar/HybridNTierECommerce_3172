using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HybridNTierECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NameDescription",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "35454ede-6f67-47bc-a7c6-1b4b0a9e9113");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec57956-3364-4ba8-a222-63388c1e0a69", new DateTime(2024, 9, 26, 12, 47, 14, 259, DateTimeKind.Local).AddTicks(3310), "AQAAAAIAAYagAAAAEMjflSX462pl0IAnNwDbhnW4Q1e4HQInZK0i6KUhXpjK3hwof5fwwuQGuA7dtDGTEw==", "dbb31ad5-c088-4578-8962-48036e713e56" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 9, 26, 9, 47, 14, 315, DateTimeKind.Utc).AddTicks(9578), "Quaerat un voluptatum cezbelendi doloremque layıkıyla alias aut vel ötekinden." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(128), "Göze sokaklarda umut ea sed sıla commodi layıkıyla velit mıknatıslı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(371), "Tv ab totam sıla yazın ipsum incidunt alias gazete quaerat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(424), "Gül et sit aperiam dışarı illo mıknatıslı gülüyorum dolayı quae." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(475), "Sarmal enim commodi odit dağılımı blanditiis için sed magni amet." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(548), "Çarpan gidecekmiş tv gitti yaptı karşıdakine çarpan aut sıla vel." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1028), "Cezbelendi magni umut tempora eve anlamsız ve kutusu quaerat incidunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1084), "Dignissimos ötekinden enim orta ut sit sandalye de gitti adresini." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1134), "Molestiae dolayı ut gidecekmiş makinesi masanın dolore numquam sit tempora." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1181), "Odio ekşili çarpan accusantium tv değirmeni lakin kutusu totam amet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1343), 642.55m, "Fantastic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1827), 991.81m, "Generic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1968), 717.71m, "Awesome Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2067), 543.72m, "Unbranded Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2247), 544.88m, "Handmade Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2339), 970.66m, "Awesome Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2482), 898.81m, "Gorgeous Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2575), 745.01m, "Tasty Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2718), 904.72m, "Ergonomic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2813), 263.55m, "Unbranded Granite Sausages" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NameDescription",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a4e1546c-ebbb-4db2-b650-3fe798d7a1c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b3fe8a-219c-40a0-a528-0b04f7f91b8e", new DateTime(2024, 9, 25, 10, 34, 36, 44, DateTimeKind.Local).AddTicks(629), "AQAAAAIAAYagAAAAEBVURTl9VEGsGyO+w7A+vdAuX40cARBZhZ3hu1RBly9BtvBS27rEqUl9xVVyPN/0Eg==", "0d39d4ae-37ac-413e-a4e3-290b0eae7887" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(7983), "Ducimus domates eaque nihil layıkıyla perferendis ekşili voluptate oldular aut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(8575), "Sed dışarı kalemi dağılımı dağılımı voluptatem de ışık aut makinesi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(8738), "Corporis dergi sokaklarda gidecekmiş quam umut iusto commodi balıkhaneye ışık." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(8811), "Numquam minima fugit in ratione ekşili consequuntur gördüm yaptı dağılımı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(8881), "Tempora çünkü deleniti türemiş uzattı accusantium dolayı ekşili sit accusantium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(8951), "Velit gülüyorum sıla magnam iusto domates çakıl lambadaki lambadaki quaerat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(9029), "Voluptatem anlamsız dolore vel consequatur architecto çobanın dignissimos architecto değirmeni." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(9129), "Cesurca voluptate quis gördüm biber beatae masaya lakin neque ea." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(9198), "Kalemi sıfat bundan yaptı blanditiis bahar velit ad labore adanaya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(9266), "Doğru minima layıkıyla exercitationem quia magnam illo dignissimos numquam voluptatum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(9400), 34.02m, "Unbranded Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 101, DateTimeKind.Utc).AddTicks(9912), 763.07m, "Unbranded Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(38), 575.12m, "Handmade Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(176), 42.09m, "Sleek Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(284), 790.46m, "Incredible Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(427), 613.50m, "Rustic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(537), 490.73m, "Tasty Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(724), 574.37m, "Sleek Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(827), 567.23m, "Sleek Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 34, 36, 102, DateTimeKind.Utc).AddTicks(967), 424.83m, "Generic Fresh Car" });
        }
    }
}
