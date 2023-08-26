using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateMassUnits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitOfMeasurement",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "MassEquivalences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    MassUnitParentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MassUnitEquivalentFactorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassEquivalences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MassUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostFix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MassEquivalenceMassUnit",
                columns: table => new
                {
                    MassEquivalencesId = table.Column<int>(type: "int", nullable: false),
                    MassUnitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassEquivalenceMassUnit", x => new { x.MassEquivalencesId, x.MassUnitsId });
                    table.ForeignKey(
                        name: "FK_MassEquivalenceMassUnit_MassEquivalences_MassEquivalencesId",
                        column: x => x.MassEquivalencesId,
                        principalTable: "MassEquivalences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MassEquivalenceMassUnit_MassUnits_MassUnitsId",
                        column: x => x.MassUnitsId,
                        principalTable: "MassUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.InsertData(
                table: "MassUnits",
                columns: new[] { "Id", "CreationDate", "Deleted", "Description", "Name", "PostFix", "UpdateDate", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3589), false, null, "Miligramos", "mg", null, true },
                    { 2, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3592), false, null, "Centigramos", "cg", null, true },
                    { 3, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3594), false, null, "Gramos", "g", null, true },
                    { 4, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3597), false, null, "Kilogramos", "kg", null, true },
                    { 5, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3599), false, null, "Quintal", "q", null, true },
                    { 6, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3601), false, null, "Tonelada", "t", null, true },
                    { 7, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3603), false, null, "Onza", "oz", null, true },
                    { 8, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3606), false, null, "Libra", "lb", null, true },
                    { 9, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3608), false, null, "TableSpoon", "tbsp", null, true },
                    { 10, new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3610), false, null, "TeaSpoon", "tsp", null, true }
                });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.CreateIndex(
                name: "IX_MassEquivalenceMassUnit_MassUnitsId",
                table: "MassEquivalenceMassUnit",
                column: "MassUnitsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MassEquivalenceMassUnit");

            migrationBuilder.DropTable(
                name: "MassEquivalences");

            migrationBuilder.DropTable(
                name: "MassUnits");

            migrationBuilder.AddColumn<int>(
                name: "UnitOfMeasurement",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UnitOfMeasurement" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2262), 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UnitOfMeasurement" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2267), 2 });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2135));
        }
    }
}
