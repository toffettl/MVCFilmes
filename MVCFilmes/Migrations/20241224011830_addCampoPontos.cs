using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCFilmes.Migrations
{
    /// <inheritdoc />
    public partial class addCampoPontos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "Filmes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Filmes");
        }
    }
}
