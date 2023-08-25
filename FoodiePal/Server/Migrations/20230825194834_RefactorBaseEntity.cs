using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class RefactorBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Users",
                newName: "CreationDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Steps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Steps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Steps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Steps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ProductTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "ProductTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ProductTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Ingredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Ingredients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Ingredients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Ingredients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Addresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Addresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2078), false, null, true });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2082), false, null, true });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2085), false, null, true });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2088), false, null, true });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2171), false, null, true });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2175), false, null, true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2152), false, null, true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2155), false, null, true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2158), false, null, true });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2262), false, null, true });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2267), false, null, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2240), false, null, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2243), false, null, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2246), false, null, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2248), false, null, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2224), false, null, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2227), false, null, true });

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
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(1933), false, null, true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(1973), false, null, true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(1975), false, null, true });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2280), false, null, true });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2283), false, null, true });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Deleted", "UpdateDate", "Visible" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2285), false, null, true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2106), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2130), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 48, 33, 999, DateTimeKind.Local).AddTicks(2135), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Users",
                newName: "DateCreated");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 25, 20, 57, 36, 192, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 25, 20, 57, 36, 192, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 25, 20, 57, 36, 192, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 25, 20, 57, 36, 192, DateTimeKind.Local).AddTicks(5474));
        }
    }
}
