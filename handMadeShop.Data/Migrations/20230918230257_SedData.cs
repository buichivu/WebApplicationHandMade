using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace handMadeShop.Data.Migrations
{
    public partial class SedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", "This is description of handMadeShop" },
                    { "HomeKeyword", "This is keyword of handMadeShop" },
                    { "HomeTitle", "This is home page of handMadeShop" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "en", false, "English" },
                    { "vi", true, "Tiếng Việt" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "IsFeatured", "OriginalPrice", "Price" },
                values: new object[] { 1, new DateTime(2023, 9, 19, 6, 2, 56, 786, DateTimeKind.Local).AddTicks(412), null, 100000m, 200000m });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi", "Hoa Giấy", "Hoa-Giay", "Sản phẩm hoa Giấy", "Sản phẩm hoa Giấ" },
                    { 2, 1, "en", "Sap Flower", "Sap-Floewr", "The Sap flower", "The Sap flower" },
                    { 3, 2, "vi", "Quà Lưu niệm", "Qua-Luu-Niem", "Sản phẩm Quà lưu niệm", "Sản phẩm Quà lưu niệm" },
                    { 4, 2, "en", "Design products as required", "Design products as required", "The Design products as required", "The Design products as required" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Hoa Hồng Giấy Màu Hồng Bó 50 bông", "Hoa Hồng Giấy Màu Hồng Bó 50 bông", "vi", "Hoa Hồng Giấy Màu Hồng Bó 50 bông", 1, "ao-so-mi-nam-trang-viet-tien", "Hoa Hồng Giấy Màu Hồng Bó 50 bông", "Hoa Hồng Giấy Màu Hồng Bó 50 bông" },
                    { 2, "ao-so-mi-nam-trang-viet-tien", "ao-so-mi-nam-trang-viet-tien", "en", "ao-so-mi-nam-trang-viet-tien", 1, "ao-so-mi-nam-trang-viet-tien", "ao-so-mi-nam-trang-viet-tien", "ao-so-mi-nam-trang-viet-tien" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
