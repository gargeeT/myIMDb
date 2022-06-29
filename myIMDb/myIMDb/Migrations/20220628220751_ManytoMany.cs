using Microsoft.EntityFrameworkCore.Migrations;

namespace myIMDb.Migrations
{
    public partial class ManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "producer_id",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MovieCast",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieCast",
                table: "MovieCast",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCast_ActorId",
                table: "MovieCast",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCast_MovieId",
                table: "MovieCast",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Actor_ActorId",
                table: "MovieCast",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Movie_MovieId",
                table: "MovieCast",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Actor_ActorId",
                table: "MovieCast");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Movie_MovieId",
                table: "MovieCast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieCast",
                table: "MovieCast");

            migrationBuilder.DropIndex(
                name: "IX_MovieCast_ActorId",
                table: "MovieCast");

            migrationBuilder.DropIndex(
                name: "IX_MovieCast_MovieId",
                table: "MovieCast");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MovieCast");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
