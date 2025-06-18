using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tiklaa_blazor_game.Migrations
{
    /// <inheritdoc />
    public partial class uondf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TiklamaSonuc",
                table: "Db_Games");

            migrationBuilder.RenameColumn(
                name: "Skor",
                table: "Db_leaders",
                newName: "Clickcount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Clickcount",
                table: "Db_leaders",
                newName: "Skor");

            migrationBuilder.AddColumn<string>(
                name: "TiklamaSonuc",
                table: "Db_Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
