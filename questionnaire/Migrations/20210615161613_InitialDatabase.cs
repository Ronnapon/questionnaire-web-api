using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace questionnaire.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answers", x => x.AnswerId);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "choices",
                columns: table => new
                {
                    ChoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Choice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_choices", x => x.ChoiceId);
                    table.ForeignKey(
                        name: "FK_choices_questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "QuestionId", "DateAdd", "Question" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 15, 23, 16, 13, 369, DateTimeKind.Local).AddTicks(6806), "Title" },
                    { 2, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7592), "First Name" },
                    { 3, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7613), "Last Name" },
                    { 4, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7616), "Date of birth" },
                    { 5, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7618), "Country of residence" },
                    { 6, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7619), "House Address" },
                    { 7, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7621), "Work Address" },
                    { 8, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7623), "Occupation" },
                    { 9, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7624), "Job Title" },
                    { 10, new DateTime(2021, 6, 15, 23, 16, 13, 370, DateTimeKind.Local).AddTicks(7626), "Business Type" }
                });

            migrationBuilder.InsertData(
                table: "choices",
                columns: new[] { "ChoiceId", "Choice", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Mr.", 1 },
                    { 2, "Ms.", 1 },
                    { 3, "Mrs.", 1 },
                    { 4, "Thailand", 5 },
                    { 5, "America", 5 },
                    { 6, "Japan", 5 },
                    { 7, "Programmer", 8 },
                    { 8, "Marketting", 8 },
                    { 9, "Software Engineer", 9 },
                    { 10, "Sales Manager", 9 },
                    { 11, "SoftwareHourse", 10 },
                    { 12, "Market", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_choices_QuestionId",
                table: "choices",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answers");

            migrationBuilder.DropTable(
                name: "choices");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "questions");
        }
    }
}
