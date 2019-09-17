using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Safari.Migrations
{
    public partial class AddedTimeLastSeenColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeLastSeen",
                table: "Animals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeLastSeen",
                table: "Animals");
        }
    }
}
