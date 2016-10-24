using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credibled.Data.Migrations
{
    public partial class migration_201610211609 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    QuestionDataType = table.Column<int>(nullable: false),
                    QuestionText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceRequest",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CandidateEndDate = table.Column<DateTime>(nullable: false),
                    CandidateId = table.Column<string>(nullable: false),
                    CandidateJobDuties = table.Column<string>(nullable: false),
                    CandidateStartDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    RefereeEmail = table.Column<string>(nullable: false),
                    RefereeEmployer = table.Column<string>(nullable: false),
                    RefereeId = table.Column<string>(nullable: false),
                    RefereeName = table.Column<string>(nullable: false),
                    RefereeTelephone = table.Column<string>(nullable: false),
                    RefereeTitle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceRequest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceRequestQuestionAnswer",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    QuestionID = table.Column<Guid>(nullable: true),
                    ReferenceRequestID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceRequestQuestionAnswer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReferenceRequestQuestionAnswer_Question_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReferenceRequestQuestionAnswer_ReferenceRequest_ReferenceRequestID",
                        column: x => x.ReferenceRequestID,
                        principalTable: "ReferenceRequest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceRequestQuestionAnswer_QuestionID",
                table: "ReferenceRequestQuestionAnswer",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceRequestQuestionAnswer_ReferenceRequestID",
                table: "ReferenceRequestQuestionAnswer",
                column: "ReferenceRequestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReferenceRequestQuestionAnswer");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ReferenceRequest");
        }
    }
}
