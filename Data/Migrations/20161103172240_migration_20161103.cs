using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credibled.Data.Migrations
{
    public partial class migration_20161103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefereeId",
                table: "ReferenceRequest");

            migrationBuilder.AddColumn<string>(
                name: "RefereeEmail",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefereeEmployer",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefereeName",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefereeTelephone",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefereeTitle",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "ReferenceRequest",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefereeEmail",
                table: "ReferenceRequest");

            migrationBuilder.DropColumn(
                name: "RefereeEmployer",
                table: "ReferenceRequest");

            migrationBuilder.DropColumn(
                name: "RefereeName",
                table: "ReferenceRequest");

            migrationBuilder.DropColumn(
                name: "RefereeTelephone",
                table: "ReferenceRequest");

            migrationBuilder.DropColumn(
                name: "RefereeTitle",
                table: "ReferenceRequest");

            migrationBuilder.AddColumn<string>(
                name: "RefereeId",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "ReferenceRequest",
                nullable: false);
        }
    }
}
