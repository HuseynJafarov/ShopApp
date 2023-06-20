using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateBasketCartWithBaseEntityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketCarts_Baskets_BasketId",
                table: "BasketCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketCarts_Carts_CartId",
                table: "BasketCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_AppUserId",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketCarts",
                table: "BasketCarts");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Basket");

            migrationBuilder.RenameTable(
                name: "BasketCarts",
                newName: "BasketCart");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_AppUserId",
                table: "Basket",
                newName: "IX_Basket_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketCarts_CartId",
                table: "BasketCart",
                newName: "IX_BasketCart_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketCarts_BasketId",
                table: "BasketCart",
                newName: "IX_BasketCart_BasketId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "BasketCart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "SoftDeleted",
                table: "BasketCart",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "BasketCart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Basket",
                table: "Basket",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketCart",
                table: "BasketCart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_AspNetUsers_AppUserId",
                table: "Basket",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketCart_Basket_BasketId",
                table: "BasketCart",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketCart_Carts_CartId",
                table: "BasketCart",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_AspNetUsers_AppUserId",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketCart_Basket_BasketId",
                table: "BasketCart");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketCart_Carts_CartId",
                table: "BasketCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketCart",
                table: "BasketCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Basket",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "BasketCart");

            migrationBuilder.DropColumn(
                name: "SoftDeleted",
                table: "BasketCart");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "BasketCart");

            migrationBuilder.RenameTable(
                name: "BasketCart",
                newName: "BasketCarts");

            migrationBuilder.RenameTable(
                name: "Basket",
                newName: "Baskets");

            migrationBuilder.RenameIndex(
                name: "IX_BasketCart_CartId",
                table: "BasketCarts",
                newName: "IX_BasketCarts_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketCart_BasketId",
                table: "BasketCarts",
                newName: "IX_BasketCarts_BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_AppUserId",
                table: "Baskets",
                newName: "IX_Baskets_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketCarts",
                table: "BasketCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketCarts_Baskets_BasketId",
                table: "BasketCarts",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketCarts_Carts_CartId",
                table: "BasketCarts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_AppUserId",
                table: "Baskets",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
