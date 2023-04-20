using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHIS_Portal.Migrations
{
    public partial class TreatmentTypeAndLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81c829c7-4629-4a53-b63d-d87b39534cc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb60a056-4db4-4ff1-813e-b755bccf7a43");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "EnroleeComplain",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentId",
                table: "EnroleeComplain",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreatmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "167d0cd3-b62b-42fd-9acd-f568d19fb3f8", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4ae6655-00fb-42a6-9158-5f3f4563423f", "2", "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_EnroleeComplain_LocationId",
                table: "EnroleeComplain",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EnroleeComplain_TreatmentId",
                table: "EnroleeComplain",
                column: "TreatmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnroleeComplain_Location_LocationId",
                table: "EnroleeComplain",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnroleeComplain_TreatmentType_TreatmentId",
                table: "EnroleeComplain",
                column: "TreatmentId",
                principalTable: "TreatmentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnroleeComplain_Location_LocationId",
                table: "EnroleeComplain");

            migrationBuilder.DropForeignKey(
                name: "FK_EnroleeComplain_TreatmentType_TreatmentId",
                table: "EnroleeComplain");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "TreatmentType");

            migrationBuilder.DropIndex(
                name: "IX_EnroleeComplain_LocationId",
                table: "EnroleeComplain");

            migrationBuilder.DropIndex(
                name: "IX_EnroleeComplain_TreatmentId",
                table: "EnroleeComplain");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "167d0cd3-b62b-42fd-9acd-f568d19fb3f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ae6655-00fb-42a6-9158-5f3f4563423f");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "EnroleeComplain");

            migrationBuilder.DropColumn(
                name: "TreatmentId",
                table: "EnroleeComplain");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81c829c7-4629-4a53-b63d-d87b39534cc0", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb60a056-4db4-4ff1-813e-b755bccf7a43", "1", "Admin", "Admin" });
        }
    }
}
