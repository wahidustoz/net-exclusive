using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace relationships.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserLicenseRealtionsship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicenses_Users_UserId",
                table: "DriverLicenses");

            migrationBuilder.DropIndex(
                name: "IX_DriverLicenses_UserId",
                table: "DriverLicenses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DriverLicenses");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicenses_Users_Id",
                table: "DriverLicenses",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicenses_Users_Id",
                table: "DriverLicenses");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "DriverLicenses",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_UserId",
                table: "DriverLicenses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicenses_Users_UserId",
                table: "DriverLicenses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
