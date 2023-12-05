using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUTHENTICATION_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class CreateEFCoreDB12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Column2",
                table: "user_Details",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Column1",
                table: "user_Details",
                newName: "password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "user_Details",
                newName: "Column2");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "user_Details",
                newName: "Column1");
        }
    }
}
