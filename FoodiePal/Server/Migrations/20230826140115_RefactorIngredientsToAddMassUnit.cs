using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class RefactorIngredientsToAddMassUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Users",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Steps",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Roles",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Recipes",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "ProductTypes",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Products",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "MassUnits",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "MassEquivalences",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Ingredients",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Categories",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Authors",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Addresses",
                newName: "LastUpdateDate");

            migrationBuilder.AddColumn<int>(
                name: "MassUnitId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9268), 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate", "MassUnitId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9272), 1 });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LastUpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 16, 1, 15, 355, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MassUnitId",
                table: "Ingredients",
                column: "MassUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_MassUnits_MassUnitId",
                table: "Ingredients",
                column: "MassUnitId",
                principalTable: "MassUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_MassUnits_MassUnitId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_MassUnitId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "MassUnitId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Users",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Steps",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Roles",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Recipes",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "ProductTypes",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Products",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "MassUnits",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "MassEquivalences",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Ingredients",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Categories",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Authors",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "Addresses",
                newName: "UpdateDate");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3387), null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3392), null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3394), null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3397), null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3530), null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3533), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3467), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3512), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3515), null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3628), null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3631), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3589), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3592), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3594), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3597), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3599), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3601), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3603), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3606), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3608), null });

            migrationBuilder.UpdateData(
                table: "MassUnits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3610), null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3565), null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3568), null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3570), null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3573), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3549), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3553), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3673), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3246), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3286), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3288), null });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3650), null });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3653), null });

            migrationBuilder.UpdateData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3655), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3418), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3441), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 22, 40, 203, DateTimeKind.Local).AddTicks(3447), null });
        }
    }
}
