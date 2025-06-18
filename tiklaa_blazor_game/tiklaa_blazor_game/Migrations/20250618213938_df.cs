using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tiklaa_blazor_game.Migrations
{
    /// <inheritdoc />
    public partial class df : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Db_leaders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Db_leaders",
                columns: table => new
                {
                    leaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clickcount = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_leaders", x => x.leaderID);
                });
        }
    }
}
