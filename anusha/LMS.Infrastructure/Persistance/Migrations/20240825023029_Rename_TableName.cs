using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Rename_TableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Questionnaire_QuestionnaireId",
                table: "Option");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaire",
                table: "Questionnaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Option",
                table: "Option");

            migrationBuilder.RenameTable(
                name: "Questionnaire",
                newName: "Questionnaires");

            migrationBuilder.RenameTable(
                name: "Option",
                newName: "Options");

            migrationBuilder.RenameIndex(
                name: "IX_Option_QuestionnaireId",
                table: "Options",
                newName: "IX_Options_QuestionnaireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Options",
                table: "Options",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Questionnaires_QuestionnaireId",
                table: "Options",
                column: "QuestionnaireId",
                principalTable: "Questionnaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Questionnaires_QuestionnaireId",
                table: "Options");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Options",
                table: "Options");

            migrationBuilder.RenameTable(
                name: "Questionnaires",
                newName: "Questionnaire");

            migrationBuilder.RenameTable(
                name: "Options",
                newName: "Option");

            migrationBuilder.RenameIndex(
                name: "IX_Options_QuestionnaireId",
                table: "Option",
                newName: "IX_Option_QuestionnaireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaire",
                table: "Questionnaire",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Option",
                table: "Option",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Questionnaire_QuestionnaireId",
                table: "Option",
                column: "QuestionnaireId",
                principalTable: "Questionnaire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
