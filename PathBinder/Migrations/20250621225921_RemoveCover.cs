using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathBinder.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCover : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Files");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Files",
                type: "TEXT",
                nullable: true);
        }
    }
}
