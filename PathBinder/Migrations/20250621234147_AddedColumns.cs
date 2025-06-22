using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathBinder.Migrations
{
    /// <inheritdoc />
    public partial class AddedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Files",
                type: "TEXT",
                maxLength: 1024,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Files",
                type: "TEXT",
                maxLength: 128,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Files");
        }
    }
}
