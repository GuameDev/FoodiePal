using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiePal.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Free" },
                    { 3, "Premium" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "Email", "LastName1", "LastName2", "Name", "PasswordHash", "PasswordSalt", "RolId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 12, 58, 7, 883, DateTimeKind.Local).AddTicks(2626), "jorge.diaz@fakeMail.com", "Díaz", "González", "Jorge", new byte[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 47, 97 }, new byte[] { 83, 97, 108, 116 }, 1 },
                    { 2, new DateTime(2023, 8, 21, 12, 58, 7, 883, DateTimeKind.Local).AddTicks(2685), "natalia.murillo@fakeMail.com", "Murillo", "Palazón", "Natalia", new byte[] { 55, 56, 57, 52, 53, 54, 49, 50, 51 }, new byte[] { 83, 97, 108, 116, 121 }, 3 },
                    { 3, new DateTime(2023, 8, 21, 12, 58, 7, 883, DateTimeKind.Local).AddTicks(2689), "mar.casal@fakeMail.com", "Casal", "Vilches", "Mar", new byte[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 47, 97 }, new byte[] { 70, 111, 111, 100, 105, 101, 80, 97, 108 }, 2 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "FirstName", "LastName", "Street", "UserId", "Zip" },
                values: new object[,]
                {
                    { 1, "Madrid", "España", "Jorge", "Díaz", "Calle Valeriano Alcalá", 1, "40521" },
                    { 2, "Madrid", "España", "María", "Martínez", "Calle Valeriano Alcalá", 1, "40521" },
                    { 3, "Murcia", "España", "Natalia", "Murillo", "Calle Paco Palazón", 2, "30256" },
                    { 4, "Murcia", "España", "César", "Sánchez", "Calle Paco Palazón", 2, "30256" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
