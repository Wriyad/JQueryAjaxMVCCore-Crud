using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD__jQueryAjaxDotNetCore_.Migrations
{
    public partial class AddedDateColum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Transactions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Transactions");
        }
    }
}
