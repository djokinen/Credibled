using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credibled.Data.Migrations
{
    public partial class migration_201610212338 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefereeTelephone",
                table: "ReferenceRequest");

            migrationBuilder.CreateTable(
                name: "Referee",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    RefereeEmail = table.Column<string>(nullable: false),
                    RefereeEmployer = table.Column<string>(nullable: false),
                    RefereeName = table.Column<string>(nullable: false),
                    RefereeTelephone = table.Column<string>(nullable: false),
                    RefereeTitle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Referee");

            migrationBuilder.AddColumn<string>(
                name: "RefereeTelephone",
                table: "ReferenceRequest",
                nullable: false,
                defaultValue: "");
        }
    }
}
