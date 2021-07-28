using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdatingDBConext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_FromPlace",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_ToplaceFKPlaceId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_ToplaceFKPlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_FromPlace",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_ToplaceFKPlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_FromPlace",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ToplaceFKPlaceId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ToplaceFKPlaceId",
                table: "Bookings_history");

            migrationBuilder.DropColumn(
                name: "ToplaceFKPlaceId",
                table: "Bookings");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_ToPlace",
                table: "Bookings_history",
                column: "ToPlace");

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_ToPlace",
                table: "Bookings_history",
                column: "ToPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_ToPlace",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_ToPlace",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_ToPlace",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ToPlace",
                table: "Bookings");

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
                name: "IX_Bookings_history_FromPlace",
                table: "Bookings_history",
                column: "FromPlace");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_ToplaceFKPlaceId",
                table: "Bookings_history",
                column: "ToplaceFKPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FromPlace",
                table: "Bookings",
                column: "FromPlace");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ToplaceFKPlaceId",
                table: "Bookings",
                column: "ToplaceFKPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Places_FromPlace",
                table: "Bookings",
                column: "FromPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Places_ToplaceFKPlaceId",
                table: "Bookings",
                column: "ToplaceFKPlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history",
                column: "FromPlace",
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
    }
}
