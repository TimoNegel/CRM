using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class _22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Status",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Status_TeamId",
                table: "Status",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Teams_TeamId",
                table: "Status",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_Teams_TeamId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_TeamId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Status");
        }
    }
}
