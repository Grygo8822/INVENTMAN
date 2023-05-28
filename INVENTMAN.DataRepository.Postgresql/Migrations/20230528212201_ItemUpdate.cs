using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INVENTMAN.DataRepository.Postgresql.Migrations
{
    public partial class ItemUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EanCode",
                table: "Items",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndOfWarranty",
                table: "Items",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EanCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "EndOfWarranty",
                table: "Items");
        }
    }
}
