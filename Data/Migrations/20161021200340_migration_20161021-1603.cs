using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credibled.Data.Migrations
{
    public partial class migration_201610211603 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AgreeToTerms",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AgreeToTermsDateTime",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCandidate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgreeToTerms",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AgreeToTermsDateTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsCandidate",
                table: "AspNetUsers");
        }
    }
}
