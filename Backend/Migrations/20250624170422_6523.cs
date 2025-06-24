using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class _6523 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Auftraege",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Auftraege_TeamId",
                table: "Auftraege",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auftraege_Teams_TeamId",
                table: "Auftraege",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auftraege_Teams_TeamId",
                table: "Auftraege");

            migrationBuilder.DropIndex(
                name: "IX_Auftraege_TeamId",
                table: "Auftraege");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Auftraege");
        }
    }
}
