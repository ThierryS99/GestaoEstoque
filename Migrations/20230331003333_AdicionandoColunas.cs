using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoEstoque.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fornecedor",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fornecedor",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Produto");
        }
    }
}
