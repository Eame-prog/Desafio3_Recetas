using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionRecetas.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreReceta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescripcionReceta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiempoReceta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreIngrediente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecetaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Recetas_RecetaId",
                        column: x => x.RecetaId,
                        principalTable: "Recetas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PasosPreparaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    RecetaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasosPreparaciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PasosPreparaciones_Recetas_RecetaId",
                        column: x => x.RecetaId,
                        principalTable: "Recetas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_RecetaId",
                table: "Ingredientes",
                column: "RecetaId");

            migrationBuilder.CreateIndex(
                name: "IX_PasosPreparaciones_RecetaId",
                table: "PasosPreparaciones",
                column: "RecetaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "PasosPreparaciones");

            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
