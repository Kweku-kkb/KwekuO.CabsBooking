using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdatingPlacesOnModelCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_ToPlace",
                table: "Bookings_history",
                column: "ToPlace");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_ToPlace",
                table: "Bookings_history",
                column: "ToPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_ToPlace",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_ToPlace",
                table: "Bookings_history");
        }
    }
}
