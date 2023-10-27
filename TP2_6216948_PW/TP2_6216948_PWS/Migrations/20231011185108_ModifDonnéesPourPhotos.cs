using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2_6216948_PWS.Migrations
{
    public partial class ModifDonnéesPourPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Logo",
                value: "nhl.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "OHL.jpg");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Logo",
                value: "lhjmq.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Logo",
                value: "/Assets/Images/NHL.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "/Assets/Images/OHL.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Logo",
                value: "/Assets/Images/lhjmq.png");
        }
    }
}
