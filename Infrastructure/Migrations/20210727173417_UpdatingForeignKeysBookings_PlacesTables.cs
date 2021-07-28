using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdatingForeignKeysBookings_PlacesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_FromPlace",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_FromPlace",
                table: "Bookings");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ToPlace",
                table: "Bookings",
                column: "ToPlace");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Places_ToPlace",
                table: "Bookings",
                column: "ToPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_ToPlace",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ToPlace",
                table: "Bookings");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FromPlace",
                table: "Bookings",
                column: "FromPlace");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Places_FromPlace",
                table: "Bookings",
                column: "FromPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
