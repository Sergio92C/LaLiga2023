using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaLiga2023.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEquiposMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    id_equipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_oficial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nombre_coloquial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    fundacion = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    estadio = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    presidente = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    web = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    entrenador = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.id_equipo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipo");
        }
    }
}
