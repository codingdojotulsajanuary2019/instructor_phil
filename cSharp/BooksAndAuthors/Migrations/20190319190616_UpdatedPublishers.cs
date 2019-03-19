using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksAndAuthors.Migrations
{
    public partial class UpdatedPublishers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publication_Books_BookId",
                table: "Publication");

            migrationBuilder.DropForeignKey(
                name: "FK_Publication_Publishers_PublisherId1",
                table: "Publication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publication",
                table: "Publication");

            migrationBuilder.DropIndex(
                name: "IX_Publication_PublisherId1",
                table: "Publication");

            migrationBuilder.DropColumn(
                name: "PublisherId1",
                table: "Publication");

            migrationBuilder.RenameTable(
                name: "Publication",
                newName: "Publications");

            migrationBuilder.RenameIndex(
                name: "IX_Publication_BookId",
                table: "Publications",
                newName: "IX_Publications_BookId");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Publishers",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publications",
                table: "Publications",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_PublisherId",
                table: "Publications",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Books_BookId",
                table: "Publications",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Publishers_PublisherId",
                table: "Publications",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Books_BookId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Publishers_PublisherId",
                table: "Publications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publications",
                table: "Publications");

            migrationBuilder.DropIndex(
                name: "IX_Publications_PublisherId",
                table: "Publications");

            migrationBuilder.RenameTable(
                name: "Publications",
                newName: "Publication");

            migrationBuilder.RenameIndex(
                name: "IX_Publications_BookId",
                table: "Publication",
                newName: "IX_Publication_BookId");

            migrationBuilder.AlterColumn<long>(
                name: "PublisherId",
                table: "Publishers",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<long>(
                name: "PublisherId1",
                table: "Publication",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publication",
                table: "Publication",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Publication_PublisherId1",
                table: "Publication",
                column: "PublisherId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Publication_Books_BookId",
                table: "Publication",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publication_Publishers_PublisherId1",
                table: "Publication",
                column: "PublisherId1",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
