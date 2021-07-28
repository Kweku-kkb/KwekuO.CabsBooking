using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdatingBBHPTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_ToPlace",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_PlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_PlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ToPlace",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Bookings_history");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_FromPlace",
                table: "Bookings_history",
                column: "FromPlace");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history",
                column: "FromPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_FromPlace",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_FromPlace",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_FromPlace",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Bookings_history",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_PlaceId",
                table: "Bookings_history",
                column: "PlaceId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_PlaceId",
                table: "Bookings_history",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
