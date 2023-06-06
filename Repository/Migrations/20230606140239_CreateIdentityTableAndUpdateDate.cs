using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateIdentityTableAndUpdateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TellUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 184, DateTimeKind.Utc).AddTicks(6293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 181, DateTimeKind.Utc).AddTicks(1787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 182, DateTimeKind.Utc).AddTicks(4083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 183, DateTimeKind.Utc).AddTicks(6593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 180, DateTimeKind.Utc).AddTicks(9272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 179, DateTimeKind.Utc).AddTicks(4055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 177, DateTimeKind.Utc).AddTicks(8012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 176, DateTimeKind.Utc).AddTicks(825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 333, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 174, DateTimeKind.Utc).AddTicks(1370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 332, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 171, DateTimeKind.Utc).AddTicks(627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 170, DateTimeKind.Utc).AddTicks(7245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 153, DateTimeKind.Utc).AddTicks(4788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 325, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TellUs");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Subscribe");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "SliderBoxs");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "HeroSliders");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CartAuthor");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "About");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Subscribe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(7857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 184, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(2703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 181, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "SliderBoxs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(7916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 182, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 336, DateTimeKind.Utc).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 183, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 335, DateTimeKind.Utc).AddTicks(1623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 180, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(5807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 179, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HeroSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 334, DateTimeKind.Utc).AddTicks(23),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 177, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 333, DateTimeKind.Utc).AddTicks(2804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 176, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 332, DateTimeKind.Utc).AddTicks(4681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 174, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "CartAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(5193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 171, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 331, DateTimeKind.Utc).AddTicks(3766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 170, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 17, 31, 53, 325, DateTimeKind.Utc).AddTicks(6916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 2, 39, 153, DateTimeKind.Utc).AddTicks(4788));
        }
    }
}
