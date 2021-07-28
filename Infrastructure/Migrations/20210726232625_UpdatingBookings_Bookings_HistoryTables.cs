using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdatingBookings_Bookings_HistoryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_CabTypes_CabTypesCabTypeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypesCabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_CabTypesCabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CabTypesCabTypeId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CabTypesCabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropColumn(
                name: "CabTypesCabTypeId",
                table: "Bookings");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_CabTypeId",
                table: "Bookings_history",
                column: "CabTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CabTypeId",
                table: "Bookings",
                column: "CabTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_CabTypes_CabTypeId",
                table: "Bookings",
                column: "CabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypeId",
                table: "Bookings_history",
                column: "CabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_CabTypes_CabTypeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_CabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CabTypeId",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "CabTypesCabTypeId",
                table: "Bookings_history",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CabTypesCabTypeId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_CabTypesCabTypeId",
                table: "Bookings_history",
                column: "CabTypesCabTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CabTypesCabTypeId",
                table: "Bookings",
                column: "CabTypesCabTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_CabTypes_CabTypesCabTypeId",
                table: "Bookings",
                column: "CabTypesCabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypesCabTypeId",
                table: "Bookings_history",
                column: "CabTypesCabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
