using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathBinder.Migrations
{
    /// <inheritdoc />
    public partial class SwapIntIdForUlid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Files",
                type: "TEXT",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Files",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 26)
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
