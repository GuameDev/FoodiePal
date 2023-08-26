using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class RefactorSeedMassUnitsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MassEquivalenceMassUnit");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7187), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7227), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7229), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7232), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7235), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7237), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7240), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7242), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7244), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7247), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7249), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7252), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7254), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7257), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7259), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7262), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7264), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7267), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7290), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7293), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7296), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7298), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7301), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7303), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7305), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7308), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7310), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7313), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7315), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7318), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7320), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7322), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7325), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7327), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7330), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7332), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7335), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7337), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7340), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7342), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7345), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7347), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7349), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7352), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7354), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7357), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7359), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7362), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7364), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7366), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7369), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7371), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7374), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7376), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7378), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7381), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7383), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7386), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7389), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7391), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7393), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7396), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7398), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7401), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7403), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7406), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7408), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7410), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7413), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7415), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7418), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7420), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7422), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7425), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7428), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7430), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7433), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7435), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7437), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7440), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7442), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7445), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7447), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7450), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7452), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7455), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7457), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7459), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7462), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7464), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7467), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7491), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7494), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7496), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7499), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7501), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7504), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7506), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7510), null });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 17, 24, 23, 908, DateTimeKind.Local).AddTicks(7512), null });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 23,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 24,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 25,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 26,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 27,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 28,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 29,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 34,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 39,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 41,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 42,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 43,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 44,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 45,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 46,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 47,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 48,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 49,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 51,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 52,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 53,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 54,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 55,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 56,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 57,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 58,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 59,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 61,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 62,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 63,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 64,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 65,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 66,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 67,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 68,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 69,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 7 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 71,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 72,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 73,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 74,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 75,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 76,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 77,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 78,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 79,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 8 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 81,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 82,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 83,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 84,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 85,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 86,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 87,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 88,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 89,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 9 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 91,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 92,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 93,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 94,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 95,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 96,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 97,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 98,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 99,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { null, 10 });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_MassUnitMassEquivalence_MassEquivalenceId",
                table: "MassUnitMassEquivalence",
                column: "MassEquivalenceId");

            migrationBuilder.CreateIndex(
                name: "IX_MassUnitMassEquivalence_MassUnitId",
                table: "MassUnitMassEquivalence",
                column: "MassUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_MassUnitMassEquivalence_MassEquivalences_MassEquivalenceId",
                table: "MassUnitMassEquivalence",
                column: "MassEquivalenceId",
                principalTable: "MassEquivalences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MassUnitMassEquivalence_MassUnits_MassUnitId",
                table: "MassUnitMassEquivalence",
                column: "MassUnitId",
                principalTable: "MassUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MassUnitMassEquivalence_MassEquivalences_MassEquivalenceId",
                table: "MassUnitMassEquivalence");

            migrationBuilder.DropForeignKey(
                name: "FK_MassUnitMassEquivalence_MassUnits_MassUnitId",
                table: "MassUnitMassEquivalence");

            migrationBuilder.DropIndex(
                name: "IX_MassUnitMassEquivalence_MassEquivalenceId",
                table: "MassUnitMassEquivalence");

            migrationBuilder.DropIndex(
                name: "IX_MassUnitMassEquivalence_MassUnitId",
                table: "MassUnitMassEquivalence");

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

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8655), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8666), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8671), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8682), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8903), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8914), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9011), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9017), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9028), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9051), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9057), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9069), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9075), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9087), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9093), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9120), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9133), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9139), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9146), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9152), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9159), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9200), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9207), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9213), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9219), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9226), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9232), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "MassEquivalences",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9332), 2 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9363), 3 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 23,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 24,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 25,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 26,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 27,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 28,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 29,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9392), 4 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 34,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 39,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9423), 5 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 41,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 42,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 43,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 44,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 45,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 46,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 47,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 48,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 49,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9453), 6 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 51,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 52,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 53,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 54,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 55,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 56,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 57,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 58,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 59,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9483), 7 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 61,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 62,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 63,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 64,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 65,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 66,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 67,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 68,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 69,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9514), 8 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 71,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 72,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 73,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 74,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 75,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 76,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 77,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 78,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 79,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9543), 9 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 81,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 82,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 83,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 84,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 85,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 86,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 87,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 88,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 89,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9570), 10 });

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 91,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 92,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 93,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 94,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 95,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 96,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 97,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 98,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 99,
                column: "LastUpdateDate",
                value: new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "MassUnitMassEquivalence",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(2023, 8, 26, 16, 57, 22, 953, DateTimeKind.Local).AddTicks(9596), 11 });

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

            migrationBuilder.CreateIndex(
                name: "IX_MassEquivalenceMassUnit_MassUnitsId",
                table: "MassEquivalenceMassUnit",
                column: "MassUnitsId");
        }
    }
}
