using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credibled.Data.Migrations
{
    public partial class migration_201610232032 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "ReferenceRequest",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CandidateId",
                table: "ReferenceRequest",
                nullable: false);
        }
    }
}
