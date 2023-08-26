using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMassUnitsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MassUnitMassEquivalence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MassUnitId = table.Column<int>(type: "int", nullable: false),
                    MassEquivalenceId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassUnitMassEquivalence", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 954, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 954, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.InsertData(
                table: "MassEquivalences",
                columns: new[] { "Id", "CreationDate", "Deleted", "LastUpdateDate", "MassUnitEquivalentFactorName", "MassUnitParentName", "Value", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8643), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8640), "Miligramos", "Miligramos", 1.0, true },
                    { 2, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8650), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8647), "Centigramos", "Miligramos", 0.10000000000000001, true },
                    { 3, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8655), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8653), "Gramos", "Miligramos", 0.001, true },
                    { 4, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8660), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8658), "Kilogramos", "Miligramos", 9.9999999999999995E-07, true },
                    { 5, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8666), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8663), "Quintal", "Miligramos", 1E-08, true },
                    { 6, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8671), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8669), "Tonelada", "Miligramos", 1.0000000000000001E-09, true },
                    { 7, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8677), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8674), "Onza", "Miligramos", 3.5274000000000001E-05, true },
                    { 8, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8682), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8680), "Libras", "Miligramos", 2.2046200000000002E-06, true },
                    { 9, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8687), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8685), "Tablespoon", "Miligramos", 0.067627999999999994, true },
                    { 10, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8693), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8691), "Teaspoon", "Miligramos", 0.20288400000000001, true },
                    { 11, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8699), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8696), "Miligramos", "Centigramos", 10.0, true },
                    { 12, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8705), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8702), "Centigramos", "Centigramos", 1.0, true },
                    { 13, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8711), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8708), "Gramos", "Centigramos", 0.01, true },
                    { 14, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8716), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8714), "Kilogramos", "Centigramos", 1.0000000000000001E-05, true },
                    { 15, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8721), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8719), "Quintal", "Centigramos", 9.9999999999999995E-08, true },
                    { 16, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8727), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8725), "Tonelada", "Centigramos", 1E-08, true },
                    { 17, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8733), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8731), "Onza", "Centigramos", 0.00035273999999999999, true },
                    { 18, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8738), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8736), "Libras", "Centigramos", 2.2046199999999999E-05, true },
                    { 19, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8744), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8742), "Tablespoon", "Centigramos", 0.0067628000000000002, true },
                    { 20, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8749), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8747), "Teaspoon", "Centigramos", 0.020288400000000002, true },
                    { 21, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8755), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8752), "Miligramos", "Gramos", 1000.0, true },
                    { 22, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8760), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8758), "Centigramos", "Gramos", 100.0, true },
                    { 23, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8766), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8763), "Gramos", "Gramos", 1.0, true },
                    { 24, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8771), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8769), "Kilogramos", "Gramos", 0.001, true },
                    { 25, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8776), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8774), "Quintal", "Gramos", 1.0000000000000001E-05, true },
                    { 26, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8782), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8779), "Tonelada", "Gramos", 9.9999999999999995E-08, true },
                    { 27, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8788), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8785), "Onza", "Gramos", 0.03527396, true },
                    { 28, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8793), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8791), "Libras", "Gramos", 0.00220462, true },
                    { 29, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8798), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8796), "Tablespoon", "Gramos", 0.067627999999999994, true },
                    { 30, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8804), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8801), "Teaspoon", "Gramos", 0.20288400000000001, true },
                    { 31, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8809), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8807), "Miligramos", "Kilogramos", 1000000.0, true },
                    { 32, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8815), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8812), "Centigramos", "Kilogramos", 100000.0, true },
                    { 33, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8820), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8818), "Gramos", "Kilogramos", 1000.0, true },
                    { 34, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8826), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8823), "Kilogramos", "Kilogramos", 1.0, true },
                    { 35, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8832), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8829), "Quintal", "Kilogramos", 0.01, true },
                    { 36, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8838), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8835), "Tonelada", "Kilogramos", 1.0000000000000001E-05, true },
                    { 37, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8843), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8841), "Onza", "Kilogramos", 35.273960000000002, true },
                    { 38, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8849), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8846), "Libras", "Kilogramos", 2.2046199999999998, true },
                    { 39, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8854), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8852), "Tablespoon", "Kilogramos", 67628.0, true },
                    { 40, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8860), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8857), "Teaspoon", "Kilogramos", 202884.0, true },
                    { 41, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8865), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8862), "Miligramos", "Quintal", 100000000.0, true },
                    { 42, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8870), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8868), "Centigramos", "Quintal", 10000000.0, true },
                    { 43, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8876), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8874), "Gramos", "Quintal", 1000000.0, true },
                    { 44, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8881), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8879), "Kilogramos", "Quintal", 1000.0, true },
                    { 45, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8887), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8884), "Quintal", "Quintal", 1.0, true },
                    { 46, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8892), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8890), "Tonelada", "Quintal", 0.001, true },
                    { 47, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8898), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8895), "Onza", "Quintal", 35273.959999999999, true },
                    { 48, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8903), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8901), "Libras", "Quintal", 2204.6199999999999, true },
                    { 49, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8908), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8906), "Tablespoon", "Quintal", 676280.0, true },
                    { 50, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8914), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8911), "Teaspoon", "Quintal", 2028840.0, true },
                    { 51, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8919), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8917), "Miligramos", "Tonelada", 1000000000.0, true },
                    { 52, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8925), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8922), "Centigramos", "Tonelada", 100000000.0, true },
                    { 53, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8960), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8957), "Gramos", "Tonelada", 10000000.0, true },
                    { 54, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8965), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8963), "Kilogramos", "Tonelada", 1000000.0, true },
                    { 55, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8971), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8969), "Quintal", "Tonelada", 1000.0, true },
                    { 56, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8977), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8974), "Tonelada", "Tonelada", 1.0, true },
                    { 57, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8982), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8980), "Onza", "Tonelada", 3527396.2000000002, true },
                    { 58, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8987), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8985), "Libras", "Tonelada", 220462.26199999999, true },
                    { 59, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8993), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8990), "Tablespoon", "Tonelada", 67628000.0, true },
                    { 60, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8999), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8996), "Teaspoon", "Tonelada", 202884000.0, true },
                    { 61, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9005), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9002), "Miligramos", "Onza", 28349.523099999999, true },
                    { 62, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9011), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9008), "Centigramos", "Onza", 2834.9523100000001, true },
                    { 63, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9017), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9014), "Gramos", "Onza", 28.349523099999999, true },
                    { 64, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9023), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9020), "Kilogramos", "Onza", 0.028349523099999999, true },
                    { 65, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9028), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9025), "Quintal", "Onza", 0.0002834952, true },
                    { 66, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9034), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9031), "Tonelada", "Onza", 2.8349519999999999E-06, true },
                    { 67, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9040), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9037), "Onza", "Onza", 1.0, true },
                    { 68, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9045), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9043), "Libras", "Onza", 0.0625, true },
                    { 69, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9051), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9049), "Tablespoon", "Onza", 2.0, true },
                    { 70, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9057), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9055), "Teaspoon", "Onza", 6.0, true },
                    { 71, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9063), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9060), "Miligramos", "Libras", 453592.37, true },
                    { 72, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9069), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9066), "Centigramos", "Libras", 45359.237000000001, true },
                    { 73, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9075), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9072), "Gramos", "Libras", 453.59237000000002, true },
                    { 74, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9081), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9078), "Kilogramos", "Libras", 0.45359237000000002, true },
                    { 75, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9087), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9084), "Quintal", "Libras", 0.0045359236999999997, true },
                    { 76, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9093), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9090), "Tonelada", "Libras", 4.5359236999999999E-05, true },
                    { 77, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9098), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9096), "Onza", "Libras", 16.0, true },
                    { 78, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9104), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9101), "Libras", "Libras", 1.0, true },
                    { 79, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9110), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9107), "Tablespoon", "Libras", 32.0, true },
                    { 80, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9115), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9113), "Teaspoon", "Libras", 96.0, true },
                    { 81, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9120), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9118), "Miligramos", "Tablespoon", 15000.0, true },
                    { 82, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9127), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9124), "Centigramos", "Tablespoon", 1500.0, true },
                    { 83, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9133), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9130), "Gramos", "Tablespoon", 15.0, true },
                    { 84, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9139), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9137), "Kilogramos", "Tablespoon", 0.014999999999999999, true },
                    { 85, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9146), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9143), "Quintal", "Tablespoon", 0.00014999999999999999, true },
                    { 86, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9152), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9149), "Tonelada", "Tablespoon", 1.5E-06, true },
                    { 87, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9159), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9156), "Onza", "Tablespoon", 0.52742999999999995, true },
                    { 88, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9165), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9162), "Libras", "Tablespoon", 0.032150699999999997, true },
                    { 89, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9171), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9169), "Tablespoon", "Tablespoon", 1.0, true },
                    { 90, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9176), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9174), "Teaspoon", "Tablespoon", 3.0, true },
                    { 91, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9183), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9180), "Miligramos", "Teaspoon", 5000.0, true },
                    { 92, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9189), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9186), "Centigramos", "Teaspoon", 500.0, true },
                    { 93, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9194), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9192), "Gramos", "Teaspoon", 5.0, true },
                    { 94, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9200), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9198), "Kilogramos", "Teaspoon", 0.0050000000000000001, true },
                    { 95, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9207), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9205), "Quintal", "Teaspoon", 5.0000000000000002E-05, true },
                    { 96, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9213), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9211), "Tonelada", "Teaspoon", 4.9999999999999998E-07, true },
                    { 97, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9219), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9217), "Onza", "Teaspoon", 0.175146, true },
                    { 98, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9226), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9223), "Libras", "Teaspoon", 0.0100584, true },
                    { 99, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9232), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9229), "Tablespoon", "Teaspoon", 0.33333299999999999, true },
                    { 100, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9239), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9236), "Teaspoon", "Teaspoon", 1.0, true }
                });

            migrationBuilder.InsertData(
                table: "MassUnitMassEquivalence",
                columns: new[] { "Id", "CreationDate", "Deleted", "LastUpdateDate", "MassEquivalenceId", "MassUnitId", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9274), 1, 1, true },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9281), 2, 1, true },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9284), 3, 1, true },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9287), 4, 1, true },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9289), 5, 1, true },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9292), 6, 1, true },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9321), 7, 1, true },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9325), 8, 1, true },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9328), 9, 1, true },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9332), 10, 2, true },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9335), 11, 2, true },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9338), 12, 2, true },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9341), 13, 2, true },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9344), 14, 2, true },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9347), 15, 2, true },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9350), 16, 2, true },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9353), 17, 2, true },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9357), 18, 2, true },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9360), 19, 2, true },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9363), 20, 3, true },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9366), 21, 3, true },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9369), 22, 3, true },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9371), 23, 3, true },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9375), 24, 3, true },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9378), 25, 3, true },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9381), 26, 3, true },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9383), 27, 3, true },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9386), 28, 3, true },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9389), 29, 3, true },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9392), 30, 4, true },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9395), 31, 4, true },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9398), 32, 4, true },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9401), 33, 4, true },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9405), 34, 4, true },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9408), 35, 4, true },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9411), 36, 4, true },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9414), 37, 4, true },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9417), 38, 4, true },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9420), 39, 4, true },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9423), 40, 5, true },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9426), 41, 5, true },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9429), 42, 5, true },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9432), 43, 5, true },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9435), 44, 5, true },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9438), 45, 5, true },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9441), 46, 5, true },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9444), 47, 5, true },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9447), 48, 5, true },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9450), 49, 5, true },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9453), 50, 6, true },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9456), 51, 6, true },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9459), 52, 6, true },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9462), 53, 6, true },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9465), 54, 6, true },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9468), 55, 6, true },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9471), 56, 6, true },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9474), 57, 6, true },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9477), 58, 6, true },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9480), 59, 6, true },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9483), 60, 7, true },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9486), 61, 7, true },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9489), 62, 7, true },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9492), 63, 7, true },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9495), 64, 7, true },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9498), 65, 7, true },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9502), 66, 7, true },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9505), 67, 7, true },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9508), 68, 7, true },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9511), 69, 7, true },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9514), 70, 8, true },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9517), 71, 8, true },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9520), 72, 8, true },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9523), 73, 8, true },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9526), 74, 8, true },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9529), 75, 8, true },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9531), 76, 8, true },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9534), 77, 8, true },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9537), 78, 8, true },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9540), 79, 8, true },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9543), 80, 9, true },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9546), 81, 9, true },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9548), 82, 9, true },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9551), 83, 9, true },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9553), 84, 9, true },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9556), 85, 9, true },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9559), 86, 9, true },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9562), 87, 9, true },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9564), 88, 9, true },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9567), 89, 9, true },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9570), 90, 10, true },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9572), 91, 10, true },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9575), 92, 10, true },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9577), 93, 10, true },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9580), 94, 10, true },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9582), 95, 10, true },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9585), 96, 10, true },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9587), 97, 10, true },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9590), 98, 10, true },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9593), 99, 10, true },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9596), 100, 11, true }
                });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 954, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 954, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 954, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 954, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8391));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MassUnitMassEquivalence");

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9129));
        }
    }
}
