using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class manytomantFluentBookauthorMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_BookAuthorMap",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Author_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookAuthorMap", x => new { x.BookId, x.Author_id });
                    table.ForeignKey(
                        name: "FK_Fluent_BookAuthorMap_Fluent_Author_Author_id",
                        column: x => x.Author_id,
                        principalTable: "Fluent_Author",
                        principalColumn: "Author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_BookAuthorMap_Fluent_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Fluent_Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookAuthorMap_Author_id",
                table: "Fluent_BookAuthorMap",
                column: "Author_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_BookAuthorMap");
        }
    }
}
