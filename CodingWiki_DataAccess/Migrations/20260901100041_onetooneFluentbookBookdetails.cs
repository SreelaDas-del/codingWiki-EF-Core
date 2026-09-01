using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class onetooneFluentbookBookdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Fluent_bookdetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_bookdetails_BookId",
                table: "Fluent_bookdetails",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_bookdetails_Fluent_Book_BookId",
                table: "Fluent_bookdetails",
                column: "BookId",
                principalTable: "Fluent_Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_bookdetails_Fluent_Book_BookId",
                table: "Fluent_bookdetails");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_bookdetails_BookId",
                table: "Fluent_bookdetails");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Fluent_bookdetails");
        }
    }
}
