using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHIS_Portal.Migrations
{
    public partial class UpdateAuthorisationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fd1fc8b-dfe3-4e87-958e-a1fbf5026f05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "560b73e3-fb3c-42b5-8c77-893765c5e23b");

            migrationBuilder.AddColumn<string>(
                name: "IssuedBy",
                table: "AuthorizationCodes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuedDate",
                table: "AuthorizationCodes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a099049-b646-4678-8cf7-dd3f68589d26", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5509d34-c364-49d9-b1b4-6b0aec837deb", "2", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a099049-b646-4678-8cf7-dd3f68589d26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5509d34-c364-49d9-b1b4-6b0aec837deb");

            migrationBuilder.DropColumn(
                name: "IssuedBy",
                table: "AuthorizationCodes");

            migrationBuilder.DropColumn(
                name: "IssuedDate",
                table: "AuthorizationCodes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fd1fc8b-dfe3-4e87-958e-a1fbf5026f05", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "560b73e3-fb3c-42b5-8c77-893765c5e23b", "2", "User", "User" });
        }
    }
}
