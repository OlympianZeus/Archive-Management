using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccessBank.Archive.Migrations
{
    /// <inheritdoc />
    public partial class dateTimeEntityDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OnBoardDate",
                table: "AppCustomers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "OnBoardDate",
                table: "AppCustomers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
