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
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(7857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(7916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(1623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(5807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 222, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(23),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 333, DateTimeKind.Utc).AddTicks(2804),
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
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 332, DateTimeKind.Utc).AddTicks(4681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 220, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(5193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(3766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 325, DateTimeKind.Utc).AddTicks(6916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 216, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CartsId = table.Column<int>(type: "int", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(2703))
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
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 224, DateTimeKind.Utc).AddTicks(3150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 223, DateTimeKind.Utc).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 222, DateTimeKind.Utc).AddTicks(5189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 221, DateTimeKind.Utc).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 333, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 220, DateTimeKind.Utc).AddTicks(5941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 332, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(8313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 219, DateTimeKind.Utc).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 15, 56, 11, 216, DateTimeKind.Utc).AddTicks(182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 325, DateTimeKind.Utc).AddTicks(6916));
        }
    }
}
