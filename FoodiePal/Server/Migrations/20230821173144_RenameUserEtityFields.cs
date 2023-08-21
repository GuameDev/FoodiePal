using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenameUserEtityFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RolId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RolId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 21, 19, 31, 43, 977, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 21, 19, 31, 43, 977, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 21, 19, 31, 43, 977, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_RolId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 21, 12, 58, 7, 883, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 21, 12, 58, 7, 883, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 21, 12, 58, 7, 883, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RolId",
                table: "Users",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
