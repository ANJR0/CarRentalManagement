using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "95b92753-40c3-4dec-a2c9-99dbcaeb729a", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "db95e085-93b2-4dfd-9b38-fd842e988185", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9c358c34-c77c-4044-a193-82a9d12780df", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEEVJK12po18/Xo0HCkSF/j1/DAx2v6zf3TooUm6C5fQZ6C/g4e4s4peStNZ2GwanYA==", null, false, "bd784e3b-39eb-4eb6-aca9-520cb6a565ec", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 15, 24, 7, 25, DateTimeKind.Local).AddTicks(611), new DateTime(2021, 11, 29, 15, 24, 7, 27, DateTimeKind.Local).AddTicks(1582), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 15, 24, 7, 27, DateTimeKind.Local).AddTicks(3506), new DateTime(2021, 11, 29, 15, 24, 7, 27, DateTimeKind.Local).AddTicks(3518), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 15, 24, 7, 29, DateTimeKind.Local).AddTicks(9179), new DateTime(2021, 11, 29, 15, 24, 7, 29, DateTimeKind.Local).AddTicks(9204), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 15, 24, 7, 29, DateTimeKind.Local).AddTicks(9216), new DateTime(2021, 11, 29, 15, 24, 7, 29, DateTimeKind.Local).AddTicks(9217), "Toyota”", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6598), new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6619), "“3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6625), new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6629), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6633), new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6636), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6640), new DateTime(2021, 11, 29, 15, 24, 7, 30, DateTimeKind.Local).AddTicks(6641), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
