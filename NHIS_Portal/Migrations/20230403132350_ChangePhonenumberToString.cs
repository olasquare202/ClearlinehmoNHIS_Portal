using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHIS_Portal.Migrations
{
    public partial class ChangePhonenumberToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5747343d-4f0e-484f-88db-2747ae0e6432");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5be641f-ac3a-48eb-97a5-04f4057b983a");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderPhoneNumber",
                table: "ProviderDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorizationCode",
                table: "EnroleeComplain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b6e4cbf-2e01-4b15-b3ba-f73002ba95cc", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "438de5c7-fe48-4b5f-b6f7-6663dd738fd6", "1", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b6e4cbf-2e01-4b15-b3ba-f73002ba95cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438de5c7-fe48-4b5f-b6f7-6663dd738fd6");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPhoneNumber",
                table: "ProviderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorizationCode",
                table: "EnroleeComplain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5747343d-4f0e-484f-88db-2747ae0e6432", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5be641f-ac3a-48eb-97a5-04f4057b983a", "2", "User", "User" });
        }
    }
}
