using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalSystem.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    car_no = table.Column<int>(type: "INTEGER", nullable: false),
                    date_of_booking = table.Column<DateTime>(type: "TEXT", nullable: false),
                    from_location = table.Column<string>(type: "TEXT", nullable: false),
                    to_location = table.Column<string>(type: "TEXT", nullable: false),
                    booked_name = table.Column<string>(type: "TEXT", nullable: false),
                    booked_phone_number = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
