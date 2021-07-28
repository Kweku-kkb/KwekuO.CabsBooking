using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CreatingPlacesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Bookings_history",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_PlaceId",
                table: "Bookings_history",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PlaceId",
                table: "Bookings",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Places_PlaceId",
                table: "Bookings",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_PlaceId",
                table: "Bookings_history",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Places_PlaceId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_PlaceId",
                table: "Bookings_history");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_history_PlaceId",
                table: "Bookings_history");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PlaceId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Bookings_history");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Bookings");
        }
    }
}
