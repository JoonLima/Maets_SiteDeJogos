using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classificacao = table.Column<int>(type: "int", nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    nivelconta = table.Column<string>(name: "nivel_conta", type: "nvarchar(max)", nullable: true),
                    tipoperfil = table.Column<int>(name: "tipo_perfil", type: "int", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
