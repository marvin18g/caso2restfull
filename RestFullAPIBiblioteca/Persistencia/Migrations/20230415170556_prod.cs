using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class prod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomcategoria = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Creadopor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificacionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    precioCompra = table.Column<double>(type: "float", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    Existencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriaId = table.Column<int>(type: "int", nullable: false),
                    Creadopor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificacionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_categoriaId",
                table: "Productos",
                column: "categoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
