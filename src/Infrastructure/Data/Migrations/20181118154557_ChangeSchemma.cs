using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.eShopWeb.Infrastructure.Data.Migrations
{
    public partial class ChangeSchemma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "app");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orders",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItems",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "CatalogType",
                newName: "CatalogType",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "CatalogBrand",
                newName: "CatalogBrand",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Catalog",
                newName: "Catalog",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Baskets",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "BasketItem",
                newName: "BasketItem",
                newSchema: "app");

            migrationBuilder.RenameSequence(
                name: "catalog_type_hilo",
                newName: "catalog_type_hilo",
                newSchema: "app");

            migrationBuilder.RenameSequence(
                name: "catalog_hilo",
                newName: "catalog_hilo",
                newSchema: "app");

            migrationBuilder.RenameSequence(
                name: "catalog_brand_hilo",
                newName: "catalog_brand_hilo",
                newSchema: "app");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "app",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                schema: "app",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "CatalogType",
                schema: "app",
                newName: "CatalogType");

            migrationBuilder.RenameTable(
                name: "CatalogBrand",
                schema: "app",
                newName: "CatalogBrand");

            migrationBuilder.RenameTable(
                name: "Catalog",
                schema: "app",
                newName: "Catalog");

            migrationBuilder.RenameTable(
                name: "Baskets",
                schema: "app",
                newName: "Baskets");

            migrationBuilder.RenameTable(
                name: "BasketItem",
                schema: "app",
                newName: "BasketItem");

            migrationBuilder.RenameSequence(
                name: "catalog_type_hilo",
                schema: "app",
                newName: "catalog_type_hilo");

            migrationBuilder.RenameSequence(
                name: "catalog_hilo",
                schema: "app",
                newName: "catalog_hilo");

            migrationBuilder.RenameSequence(
                name: "catalog_brand_hilo",
                schema: "app",
                newName: "catalog_brand_hilo");
        }
    }
}
