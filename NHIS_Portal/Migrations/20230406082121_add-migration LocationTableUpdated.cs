using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHIS_Portal.Migrations
{
    public partial class addmigrationLocationTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "673b80ba-485f-4e02-bc47-94b58e6f6f64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0281a7d-9e1c-4803-bc69-773397e6dd72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a120d3-6106-4d85-ab7a-bcf603145495", "2", "User", "User" },
                    { "e114c111-da78-4733-aae5-50ba70f7e3a3", "1", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Abuja" },
                    { 2, "Benin" },
                    { 3, "Enugu" },
                    { 4, "Gombe" },
                    { 5, "Ibadan" },
                    { 6, "Ife" },
                    { 7, "Kaduna" },
                    { 8, "Kano" },
                    { 9, "Lagos" },
                    { 10, "Maiduguri" },
                    { 11, "Port Harcourt" }
                });

            migrationBuilder.InsertData(
                table: "TreatmentType",
                columns: new[] { "Id", "TreatmentName" },
                values: new object[,]
                {
                    { 1, "Admission" },
                    { 2, "Antenatal" },
                    { 3, "Surgery" },
                    { 4, "Others" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a120d3-6106-4d85-ab7a-bcf603145495");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e114c111-da78-4733-aae5-50ba70f7e3a3");

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TreatmentType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TreatmentType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TreatmentType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TreatmentType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "673b80ba-485f-4e02-bc47-94b58e6f6f64", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0281a7d-9e1c-4803-bc69-773397e6dd72", "2", "User", "User" });
        }
    }
}
