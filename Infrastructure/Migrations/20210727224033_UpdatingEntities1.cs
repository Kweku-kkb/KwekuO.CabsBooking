using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdatingEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToplaceFKPlaceId",
                table: "Bookings_history",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToplaceFKPlaceId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_ToplaceFKPlaceId",
                table: "Bookings_history",
                column: "ToplaceFKPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ToplaceFKPlaceId",
                table: "Bookings",
                column: "ToplaceFKPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Places_ToplaceFKPlaceId",
                table: "Bookings",
                column: "ToplaceFKPlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_ToplaceFKPlaceId",
                table: "Bookings_history",
                column: "ToplaceFKPlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_ToplaceFKPlaceId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_ToplaceFKPlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_ToplaceFKPlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ToplaceFKPlaceId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ToplaceFKPlaceId",
                table: "Bookings_history");

            migrationBuilder.DropColumn(
                name: "ToplaceFKPlaceId",
                table: "Bookings");
        }
    }
}
