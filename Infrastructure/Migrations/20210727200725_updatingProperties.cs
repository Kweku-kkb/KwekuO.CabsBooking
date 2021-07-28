using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class updatingProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history");

            migrationBuilder.AlterColumn<int>(
                name: "ToPlace",
                table: "Bookings_history",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PickupDate",
                table: "Bookings_history",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "FromPlace",
                table: "Bookings_history",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CabTypeId",
                table: "Bookings_history",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingDate",
                table: "Bookings_history",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypeId",
                table: "Bookings_history",
                column: "CabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history",
                column: "FromPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypeId",
                table: "Bookings_history");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history");

            migrationBuilder.AlterColumn<int>(
                name: "ToPlace",
                table: "Bookings_history",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PickupDate",
                table: "Bookings_history",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FromPlace",
                table: "Bookings_history",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CabTypeId",
                table: "Bookings_history",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingDate",
                table: "Bookings_history",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_CabTypes_CabTypeId",
                table: "Bookings_history",
                column: "CabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_history_Places_FromPlace",
                table: "Bookings_history",
                column: "FromPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
