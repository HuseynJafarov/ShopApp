using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateCartAuthorRelationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(7880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 184, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 182, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(3150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 183, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 180, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 222, DateTimeKind.Utc).AddTicks(5189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 178, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 176, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 175, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 220, DateTimeKind.Utc).AddTicks(5941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 173, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 216, DateTimeKind.Utc).AddTicks(182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 169, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(7209))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartsId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(8313))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartAuthor_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartAuthor_AuthorId",
                table: "CartAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_CartAuthor_CartsId",
                table: "CartAuthor",
                column: "CartsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartAuthor");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 184, DateTimeKind.Utc).AddTicks(6185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 182, DateTimeKind.Utc).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 183, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 180, DateTimeKind.Utc).AddTicks(7205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 178, DateTimeKind.Utc).AddTicks(2978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 222, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 176, DateTimeKind.Utc).AddTicks(7694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 175, DateTimeKind.Utc).AddTicks(417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 173, DateTimeKind.Utc).AddTicks(3240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 220, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 25, 12, 28, 21, 169, DateTimeKind.Utc).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 216, DateTimeKind.Utc).AddTicks(182));
        }
    }
}
