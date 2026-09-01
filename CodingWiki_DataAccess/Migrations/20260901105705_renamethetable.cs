using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class renamethetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Authors_Author_id",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Books_BookId",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Author_Author_id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Book_BookId",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthorMap",
                newName: "Fluent_bookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "BookAuthorMap",
                newName: "bookAuthorMaps");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthorMap_Author_id",
                table: "Fluent_bookAuthorMaps",
                newName: "IX_Fluent_bookAuthorMaps_Author_id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMap_Author_id",
                table: "bookAuthorMaps",
                newName: "IX_bookAuthorMaps_Author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_bookAuthorMaps",
                table: "Fluent_bookAuthorMaps",
                columns: new[] { "BookId", "Author_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookAuthorMaps",
                table: "bookAuthorMaps",
                columns: new[] { "BookId", "Author_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthorMaps_Authors_Author_id",
                table: "bookAuthorMaps",
                column: "Author_id",
                principalTable: "Authors",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthorMaps_Books_BookId",
                table: "bookAuthorMaps",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_bookAuthorMaps_Fluent_Author_Author_id",
                table: "Fluent_bookAuthorMaps",
                column: "Author_id",
                principalTable: "Fluent_Author",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_bookAuthorMaps_Fluent_Book_BookId",
                table: "Fluent_bookAuthorMaps",
                column: "BookId",
                principalTable: "Fluent_Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthorMaps_Authors_Author_id",
                table: "bookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthorMaps_Books_BookId",
                table: "bookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_bookAuthorMaps_Fluent_Author_Author_id",
                table: "Fluent_bookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_bookAuthorMaps_Fluent_Book_BookId",
                table: "Fluent_bookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_bookAuthorMaps",
                table: "Fluent_bookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookAuthorMaps",
                table: "bookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "Fluent_bookAuthorMaps",
                newName: "Fluent_BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "bookAuthorMaps",
                newName: "BookAuthorMap");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_bookAuthorMaps_Author_id",
                table: "Fluent_BookAuthorMap",
                newName: "IX_Fluent_BookAuthorMap_Author_id");

            migrationBuilder.RenameIndex(
                name: "IX_bookAuthorMaps_Author_id",
                table: "BookAuthorMap",
                newName: "IX_BookAuthorMap_Author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap",
                columns: new[] { "BookId", "Author_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap",
                columns: new[] { "BookId", "Author_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Authors_Author_id",
                table: "BookAuthorMap",
                column: "Author_id",
                principalTable: "Authors",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Books_BookId",
                table: "BookAuthorMap",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Author_Author_id",
                table: "Fluent_BookAuthorMap",
                column: "Author_id",
                principalTable: "Fluent_Author",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Book_BookId",
                table: "Fluent_BookAuthorMap",
                column: "BookId",
                principalTable: "Fluent_Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
