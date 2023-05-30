using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateStudentTableAndCartsRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 233, DateTimeKind.Utc).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 232, DateTimeKind.Utc).AddTicks(2681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 232, DateTimeKind.Utc).AddTicks(9308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 231, DateTimeKind.Utc).AddTicks(6825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 231, DateTimeKind.Utc).AddTicks(414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 222, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 230, DateTimeKind.Utc).AddTicks(3895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 229, DateTimeKind.Utc).AddTicks(6892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.AddColumn<DateTime>(
                name: "EventDate",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 228, DateTimeKind.Utc).AddTicks(9004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 220, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 228, DateTimeKind.Utc).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 227, DateTimeKind.Utc).AddTicks(9668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 221, DateTimeKind.Utc).AddTicks(4135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 216, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CartsId = table.Column<int>(type: "int", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_CartsId",
                table: "Student",
                column: "CartsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropColumn(
                name: "EventDate",
                table: "Events");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(7880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 233, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 232, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(3150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 232, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 231, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 222, DateTimeKind.Utc).AddTicks(5189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 231, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 230, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 229, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 220, DateTimeKind.Utc).AddTicks(5941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 228, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(8313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 228, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 227, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 216, DateTimeKind.Utc).AddTicks(182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 27, 28, 221, DateTimeKind.Utc).AddTicks(4135));
        }
    }
}
