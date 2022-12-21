using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class EditandoCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "admin",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Perfil",
                table: "Usuarios",
                newName: "tipo_perfil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "tipo_perfil",
                table: "Usuarios",
                newName: "Perfil");

            migrationBuilder.AddColumn<bool>(
                name: "admin",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
