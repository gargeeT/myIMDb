using Microsoft.EntityFrameworkCore.Migrations;

namespace myIMDb.Migrations
{
    public partial class ProducerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "Producer");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "MovieCasts",
                newName: "MovieCast");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Movie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "producer_id",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producer",
                table: "Producer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProducerId",
                table: "Movie",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producer",
                table: "Producer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_ProducerId",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "producer_id",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Producer",
                newName: "Producer");

            migrationBuilder.RenameTable(
                name: "MovieCast",
                newName: "MovieCasts");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actor",
                column: "Id");
        }
    }
}
