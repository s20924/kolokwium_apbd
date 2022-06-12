using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przedKolokwium1.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_MusicLabel_IdMusicLabel",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Musician_Track_Musician_IdMusician",
                table: "Musician_Track");

            migrationBuilder.DropForeignKey(
                name: "FK_Musician_Track_Track_IdTrack",
                table: "Musician_Track");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_Album_IdMusicAlbum",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Track",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicLabel",
                table: "MusicLabel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musician_Track",
                table: "Musician_Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musician",
                table: "Musician");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Album",
                table: "Album");

            migrationBuilder.RenameTable(
                name: "Track",
                newName: "Tracks");

            migrationBuilder.RenameTable(
                name: "MusicLabel",
                newName: "MusicLabels");

            migrationBuilder.RenameTable(
                name: "Musician_Track",
                newName: "Musician_Tracks");

            migrationBuilder.RenameTable(
                name: "Musician",
                newName: "Musicians");

            migrationBuilder.RenameTable(
                name: "Album",
                newName: "Albums");

            migrationBuilder.RenameIndex(
                name: "IX_Track_IdMusicAlbum",
                table: "Tracks",
                newName: "IX_Tracks_IdMusicAlbum");

            migrationBuilder.RenameIndex(
                name: "IX_Musician_Track_IdMusician",
                table: "Musician_Tracks",
                newName: "IX_Musician_Tracks_IdMusician");

            migrationBuilder.RenameIndex(
                name: "IX_Album_IdMusicLabel",
                table: "Albums",
                newName: "IX_Albums_IdMusicLabel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "IdTrack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicLabels",
                table: "MusicLabels",
                column: "IdMusicLabel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musician_Tracks",
                table: "Musician_Tracks",
                columns: new[] { "IdTrack", "IdMusician" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musicians",
                table: "Musicians",
                column: "IdMusician");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "IdAlbum");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 34, 36, 147, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 34, 36, 147, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_MusicLabels_IdMusicLabel",
                table: "Albums",
                column: "IdMusicLabel",
                principalTable: "MusicLabels",
                principalColumn: "IdMusicLabel",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musician_Tracks_Musicians_IdMusician",
                table: "Musician_Tracks",
                column: "IdMusician",
                principalTable: "Musicians",
                principalColumn: "IdMusician",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musician_Tracks_Tracks_IdTrack",
                table: "Musician_Tracks",
                column: "IdTrack",
                principalTable: "Tracks",
                principalColumn: "IdTrack",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_IdMusicAlbum",
                table: "Tracks",
                column: "IdMusicAlbum",
                principalTable: "Albums",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_MusicLabels_IdMusicLabel",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Musician_Tracks_Musicians_IdMusician",
                table: "Musician_Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Musician_Tracks_Tracks_IdTrack",
                table: "Musician_Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_IdMusicAlbum",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicLabels",
                table: "MusicLabels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musicians",
                table: "Musicians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musician_Tracks",
                table: "Musician_Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "Track");

            migrationBuilder.RenameTable(
                name: "MusicLabels",
                newName: "MusicLabel");

            migrationBuilder.RenameTable(
                name: "Musicians",
                newName: "Musician");

            migrationBuilder.RenameTable(
                name: "Musician_Tracks",
                newName: "Musician_Track");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Album");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_IdMusicAlbum",
                table: "Track",
                newName: "IX_Track_IdMusicAlbum");

            migrationBuilder.RenameIndex(
                name: "IX_Musician_Tracks_IdMusician",
                table: "Musician_Track",
                newName: "IX_Musician_Track_IdMusician");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_IdMusicLabel",
                table: "Album",
                newName: "IX_Album_IdMusicLabel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Track",
                table: "Track",
                column: "IdTrack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicLabel",
                table: "MusicLabel",
                column: "IdMusicLabel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musician",
                table: "Musician",
                column: "IdMusician");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musician_Track",
                table: "Musician_Track",
                columns: new[] { "IdTrack", "IdMusician" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Album",
                table: "Album",
                column: "IdAlbum");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "IdAlbum",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 13, 52, 296, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "IdAlbum",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 13, 52, 296, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.AddForeignKey(
                name: "FK_Album_MusicLabel_IdMusicLabel",
                table: "Album",
                column: "IdMusicLabel",
                principalTable: "MusicLabel",
                principalColumn: "IdMusicLabel",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musician_Track_Musician_IdMusician",
                table: "Musician_Track",
                column: "IdMusician",
                principalTable: "Musician",
                principalColumn: "IdMusician",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musician_Track_Track_IdTrack",
                table: "Musician_Track",
                column: "IdTrack",
                principalTable: "Track",
                principalColumn: "IdTrack",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Album_IdMusicAlbum",
                table: "Track",
                column: "IdMusicAlbum",
                principalTable: "Album",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
