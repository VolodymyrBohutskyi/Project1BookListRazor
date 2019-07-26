using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_1_Book_List_Razor.Data.Migrations
{
    public partial class AddFieldPublishingDateToBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishingDate",
                table: "Book",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishingDate",
                table: "Book");
        }
    }
}
