using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NumberIncrementAPI.Migrations
{
    /// <inheritdoc />
    public partial class addDateFromFrontProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(name: "DateFromFront", table: "Numbers", nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DateFromFront", table: "Numbers");
        }
    }
}
