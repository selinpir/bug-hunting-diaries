using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tiklaa_blazor_game.Migrations
{
    /// <inheritdoc />
    public partial class m1223 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Db_leaders",
                columns: table => new
                {
                    leaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_leaders", x => x.leaderID);
                });

            migrationBuilder.CreateTable(
                name: "Db_Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Db_Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiklamaSonuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skor = table.Column<int>(type: "int", nullable: false),
                    ClickCount = table.Column<int>(type: "int", nullable: false),
                    Animal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Games", x => x.GameID);
                    table.ForeignKey(
                        name: "FK_Db_Games_Db_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Db_Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Db_Games_UserID",
                table: "Db_Games",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Db_Games");

            migrationBuilder.DropTable(
                name: "Db_leaders");

            migrationBuilder.DropTable(
                name: "Db_Users");
        }
    }
}
