using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddModelsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "F2_CATEGORY",
                columns: table => new
                {
                    ID_CATEGORY = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_CATEGORY", x => x.ID_CATEGORY);
                });

            migrationBuilder.CreateTable(
                name: "F2_COUNTRY",
                columns: table => new
                {
                    ID_COUNTRY = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY_CODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAG_ROUTE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_COUNTRY", x => x.ID_COUNTRY);
                });

            migrationBuilder.CreateTable(
                name: "F2_STATS",
                columns: table => new
                {
                    ID_STATS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RACE_STARTS = table.Column<int>(type: "int", nullable: false),
                    WINS = table.Column<int>(type: "int", nullable: false),
                    TOP3 = table.Column<int>(type: "int", nullable: false),
                    TOP5 = table.Column<int>(type: "int", nullable: false),
                    TOP10 = table.Column<int>(type: "int", nullable: false),
                    POLES = table.Column<int>(type: "int", nullable: false),
                    FASTEST_LAPS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_STATS", x => x.ID_STATS);
                });

            migrationBuilder.CreateTable(
                name: "F2_COMPETITION",
                columns: table => new
                {
                    ID_COMPETITION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLAYOFFS_ON_CHAMPIONSHIP = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_COMPETITION", x => x.ID_COMPETITION);
                    table.ForeignKey(
                        name: "FK_F2_COMPETITION_F2_CATEGORY_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "F2_CATEGORY",
                        principalColumn: "ID_CATEGORY");
                });

            migrationBuilder.CreateTable(
                name: "F2_DRIVER",
                columns: table => new
                {
                    ID_DRIVER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMAGE_ROUTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_COUNTRY = table.Column<int>(type: "int", nullable: false),
                    ID_STATS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_DRIVER", x => x.ID_DRIVER);
                    table.ForeignKey(
                        name: "FK_F2_DRIVER_F2_COUNTRY_ID_COUNTRY",
                        column: x => x.ID_COUNTRY,
                        principalTable: "F2_COUNTRY",
                        principalColumn: "ID_COUNTRY",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F2_DRIVER_F2_STATS_ID_STATS",
                        column: x => x.ID_STATS,
                        principalTable: "F2_STATS",
                        principalColumn: "ID_STATS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F2_TEAM",
                columns: table => new
                {
                    ID_TEAM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_STATS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_TEAM", x => x.ID_TEAM);
                    table.ForeignKey(
                        name: "FK_F2_TEAM_F2_STATS_ID_STATS",
                        column: x => x.ID_STATS,
                        principalTable: "F2_STATS",
                        principalColumn: "ID_STATS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F2_FAST_LAP",
                columns: table => new
                {
                    ID_FAST_LAP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LAP_TIME = table.Column<TimeOnly>(type: "time", nullable: false),
                    ID_DRIVER = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_FAST_LAP", x => x.ID_FAST_LAP);
                    table.ForeignKey(
                        name: "FK_F2_FAST_LAP_F2_DRIVER_ID_DRIVER",
                        column: x => x.ID_DRIVER,
                        principalTable: "F2_DRIVER",
                        principalColumn: "ID_DRIVER",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F2_DRIVER_COMPETITION",
                columns: table => new
                {
                    ID_F2_DRIVER_COMPETITION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DRIVER = table.Column<int>(type: "int", nullable: false),
                    ID_COMPETITION = table.Column<int>(type: "int", nullable: false),
                    ID_TEAM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_DRIVER_COMPETITION", x => x.ID_F2_DRIVER_COMPETITION);
                    table.ForeignKey(
                        name: "FK_F2_DRIVER_COMPETITION_F2_COMPETITION_ID_COMPETITION",
                        column: x => x.ID_COMPETITION,
                        principalTable: "F2_COMPETITION",
                        principalColumn: "ID_COMPETITION",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F2_DRIVER_COMPETITION_F2_DRIVER_ID_DRIVER",
                        column: x => x.ID_DRIVER,
                        principalTable: "F2_DRIVER",
                        principalColumn: "ID_DRIVER",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F2_DRIVER_COMPETITION_F2_TEAM_ID_TEAM",
                        column: x => x.ID_TEAM,
                        principalTable: "F2_TEAM",
                        principalColumn: "ID_TEAM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F2_CIRCUIT",
                columns: table => new
                {
                    ID_CIRCUIT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMAGE_ROUTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_COUNTRY = table.Column<int>(type: "int", nullable: false),
                    ID_FASTEST_LAP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_CIRCUIT", x => x.ID_CIRCUIT);
                    table.ForeignKey(
                        name: "FK_F2_CIRCUIT_F2_COUNTRY_ID_COUNTRY",
                        column: x => x.ID_COUNTRY,
                        principalTable: "F2_COUNTRY",
                        principalColumn: "ID_COUNTRY",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F2_CIRCUIT_F2_FAST_LAP_ID_FASTEST_LAP",
                        column: x => x.ID_FASTEST_LAP,
                        principalTable: "F2_FAST_LAP",
                        principalColumn: "ID_FAST_LAP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F2_RACE",
                columns: table => new
                {
                    ID_RACE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_CIRCUIT = table.Column<int>(type: "int", nullable: false),
                    IMAGE_ROUTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAP_NUMBER = table.Column<int>(type: "int", nullable: false),
                    ID_COUNTRY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F2_RACE", x => x.ID_RACE);
                    table.ForeignKey(
                        name: "FK_F2_RACE_F2_CIRCUIT_ID_CIRCUIT",
                        column: x => x.ID_CIRCUIT,
                        principalTable: "F2_CIRCUIT",
                        principalColumn: "ID_CIRCUIT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F2_RACE_F2_COUNTRY_ID_COUNTRY",
                        column: x => x.ID_COUNTRY,
                        principalTable: "F2_COUNTRY",
                        principalColumn: "ID_COUNTRY",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_F2_CIRCUIT_ID_COUNTRY",
                table: "F2_CIRCUIT",
                column: "ID_COUNTRY");

            migrationBuilder.CreateIndex(
                name: "IX_F2_CIRCUIT_ID_FASTEST_LAP",
                table: "F2_CIRCUIT",
                column: "ID_FASTEST_LAP");

            migrationBuilder.CreateIndex(
                name: "IX_F2_COMPETITION_CategoryId",
                table: "F2_COMPETITION",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_F2_DRIVER_ID_COUNTRY",
                table: "F2_DRIVER",
                column: "ID_COUNTRY");

            migrationBuilder.CreateIndex(
                name: "IX_F2_DRIVER_ID_STATS",
                table: "F2_DRIVER",
                column: "ID_STATS");

            migrationBuilder.CreateIndex(
                name: "IX_F2_DRIVER_COMPETITION_ID_COMPETITION",
                table: "F2_DRIVER_COMPETITION",
                column: "ID_COMPETITION");

            migrationBuilder.CreateIndex(
                name: "IX_F2_DRIVER_COMPETITION_ID_DRIVER",
                table: "F2_DRIVER_COMPETITION",
                column: "ID_DRIVER");

            migrationBuilder.CreateIndex(
                name: "IX_F2_DRIVER_COMPETITION_ID_TEAM",
                table: "F2_DRIVER_COMPETITION",
                column: "ID_TEAM");

            migrationBuilder.CreateIndex(
                name: "IX_F2_FAST_LAP_ID_DRIVER",
                table: "F2_FAST_LAP",
                column: "ID_DRIVER");

            migrationBuilder.CreateIndex(
                name: "IX_F2_RACE_ID_CIRCUIT",
                table: "F2_RACE",
                column: "ID_CIRCUIT");

            migrationBuilder.CreateIndex(
                name: "IX_F2_RACE_ID_COUNTRY",
                table: "F2_RACE",
                column: "ID_COUNTRY");

            migrationBuilder.CreateIndex(
                name: "IX_F2_TEAM_ID_STATS",
                table: "F2_TEAM",
                column: "ID_STATS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F2_DRIVER_COMPETITION");

            migrationBuilder.DropTable(
                name: "F2_RACE");

            migrationBuilder.DropTable(
                name: "F2_COMPETITION");

            migrationBuilder.DropTable(
                name: "F2_TEAM");

            migrationBuilder.DropTable(
                name: "F2_CIRCUIT");

            migrationBuilder.DropTable(
                name: "F2_CATEGORY");

            migrationBuilder.DropTable(
                name: "F2_FAST_LAP");

            migrationBuilder.DropTable(
                name: "F2_DRIVER");

            migrationBuilder.DropTable(
                name: "F2_COUNTRY");

            migrationBuilder.DropTable(
                name: "F2_STATS");
        }
    }
}
