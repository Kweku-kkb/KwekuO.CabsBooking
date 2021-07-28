using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class BookingsHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    FromPlace = table.Column<int>(type: "int", nullable: false),
                    ToPlace = table.Column<int>(type: "int", nullable: false),
                    PickupAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PickupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickupTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CabTypeId = table.Column<int>(type: "int", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    comp_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    money = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CabTypesCabTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_history_CabTypes_CabTypesCabTypeId",
                        column: x => x.CabTypesCabTypeId,
                        principalTable: "CabTypes",
                        principalColumn: "CabTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_history_CabTypesCabTypeId",
                table: "Bookings_history",
                column: "CabTypesCabTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings_history");
        }
    }
}
