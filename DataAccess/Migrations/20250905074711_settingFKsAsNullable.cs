using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class settingFKsAsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F2_CIRCUIT_F2_COUNTRY_ID_COUNTRY",
                table: "F2_CIRCUIT");

            migrationBuilder.DropForeignKey(
                name: "FK_F2_CIRCUIT_F2_FAST_LAP_ID_FASTEST_LAP",
                table: "F2_CIRCUIT");

            migrationBuilder.DropForeignKey(
                name: "FK_F2_FAST_LAP_F2_DRIVER_ID_DRIVER",
                table: "F2_FAST_LAP");

            migrationBuilder.DropForeignKey(
                name: "FK_F2_RACE_F2_CIRCUIT_ID_CIRCUIT",
                table: "F2_RACE");

            migrationBuilder.AlterColumn<int>(
                name: "ID_STATS",
                table: "F2_TEAM",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_COUNTRY",
                table: "F2_RACE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_CIRCUIT",
                table: "F2_RACE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_DRIVER",
                table: "F2_FAST_LAP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_TEAM",
                table: "F2_DRIVER_COMPETITION",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_COMPETITION",
                table: "F2_DRIVER_COMPETITION",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_STATS",
                table: "F2_DRIVER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_COUNTRY",
                table: "F2_DRIVER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_FASTEST_LAP",
                table: "F2_CIRCUIT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_COUNTRY",
                table: "F2_CIRCUIT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_F2_CIRCUIT_F2_COUNTRY_ID_COUNTRY",
                table: "F2_CIRCUIT",
                column: "ID_COUNTRY",
                principalTable: "F2_COUNTRY",
                principalColumn: "ID_COUNTRY");

            migrationBuilder.AddForeignKey(
                name: "FK_F2_CIRCUIT_F2_FAST_LAP_ID_FASTEST_LAP",
                table: "F2_CIRCUIT",
                column: "ID_FASTEST_LAP",
                principalTable: "F2_FAST_LAP",
                principalColumn: "ID_FAST_LAP");

            migrationBuilder.AddForeignKey(
                name: "FK_F2_FAST_LAP_F2_DRIVER_ID_DRIVER",
                table: "F2_FAST_LAP",
                column: "ID_DRIVER",
                principalTable: "F2_DRIVER",
                principalColumn: "ID_DRIVER");

            migrationBuilder.AddForeignKey(
                name: "FK_F2_RACE_F2_CIRCUIT_ID_CIRCUIT",
                table: "F2_RACE",
                column: "ID_CIRCUIT",
                principalTable: "F2_CIRCUIT",
                principalColumn: "ID_CIRCUIT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F2_CIRCUIT_F2_COUNTRY_ID_COUNTRY",
                table: "F2_CIRCUIT");

            migrationBuilder.DropForeignKey(
                name: "FK_F2_CIRCUIT_F2_FAST_LAP_ID_FASTEST_LAP",
                table: "F2_CIRCUIT");

            migrationBuilder.DropForeignKey(
                name: "FK_F2_FAST_LAP_F2_DRIVER_ID_DRIVER",
                table: "F2_FAST_LAP");

            migrationBuilder.DropForeignKey(
                name: "FK_F2_RACE_F2_CIRCUIT_ID_CIRCUIT",
                table: "F2_RACE");

            migrationBuilder.AlterColumn<int>(
                name: "ID_STATS",
                table: "F2_TEAM",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_COUNTRY",
                table: "F2_RACE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_CIRCUIT",
                table: "F2_RACE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_DRIVER",
                table: "F2_FAST_LAP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_TEAM",
                table: "F2_DRIVER_COMPETITION",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_COMPETITION",
                table: "F2_DRIVER_COMPETITION",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_STATS",
                table: "F2_DRIVER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_COUNTRY",
                table: "F2_DRIVER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_FASTEST_LAP",
                table: "F2_CIRCUIT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_COUNTRY",
                table: "F2_CIRCUIT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_F2_CIRCUIT_F2_COUNTRY_ID_COUNTRY",
                table: "F2_CIRCUIT",
                column: "ID_COUNTRY",
                principalTable: "F2_COUNTRY",
                principalColumn: "ID_COUNTRY",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_F2_CIRCUIT_F2_FAST_LAP_ID_FASTEST_LAP",
                table: "F2_CIRCUIT",
                column: "ID_FASTEST_LAP",
                principalTable: "F2_FAST_LAP",
                principalColumn: "ID_FAST_LAP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_F2_FAST_LAP_F2_DRIVER_ID_DRIVER",
                table: "F2_FAST_LAP",
                column: "ID_DRIVER",
                principalTable: "F2_DRIVER",
                principalColumn: "ID_DRIVER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_F2_RACE_F2_CIRCUIT_ID_CIRCUIT",
                table: "F2_RACE",
                column: "ID_CIRCUIT",
                principalTable: "F2_CIRCUIT",
                principalColumn: "ID_CIRCUIT",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
