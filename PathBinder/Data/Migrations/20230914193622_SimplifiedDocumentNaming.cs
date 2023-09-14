using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathBinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class SimplifiedDocumentNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "documentText",
                table: "Document",
                newName: "Content");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Document",
                newName: "documentText");
        }
    }
}
