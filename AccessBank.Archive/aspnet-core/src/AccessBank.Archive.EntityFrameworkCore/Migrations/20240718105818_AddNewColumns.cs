using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccessBank.Archive.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account_number",
                table: "AppCustomers");

            migrationBuilder.RenameColumn(
                name: "Branch_code",
                table: "AppCustomers",
                newName: "BranchCode");

            migrationBuilder.RenameColumn(
                name: "Account_Name",
                table: "AppCustomers",
                newName: "AccountName");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "AppCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "AppCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "AppCustomers");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "AppCustomers");

            migrationBuilder.RenameColumn(
                name: "BranchCode",
                table: "AppCustomers",
                newName: "Branch_code");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "AppCustomers",
                newName: "Account_Name");

            migrationBuilder.AddColumn<int>(
                name: "Account_number",
                table: "AppCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
