using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHIS_Portal.Migrations
{
    public partial class ComplainTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "849517d4-365b-4415-8f1d-0b835e4224cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7eed353-5057-4441-a5c9-28a1b7ba8fa5");

            migrationBuilder.CreateTable(
                name: "ProviderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    HMO_Officer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HMO_Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnroleeComplain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorizationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnroleeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnroleeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnroleeComplain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnroleeComplain_ProviderDetails_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "ProviderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5747343d-4f0e-484f-88db-2747ae0e6432", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5be641f-ac3a-48eb-97a5-04f4057b983a", "2", "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_EnroleeComplain_ProviderId",
                table: "EnroleeComplain",
                column: "ProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnroleeComplain");

            migrationBuilder.DropTable(
                name: "ProviderDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5747343d-4f0e-484f-88db-2747ae0e6432");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5be641f-ac3a-48eb-97a5-04f4057b983a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "849517d4-365b-4415-8f1d-0b835e4224cc", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7eed353-5057-4441-a5c9-28a1b7ba8fa5", "1", "Admin", "Admin" });
        }
    }
}
