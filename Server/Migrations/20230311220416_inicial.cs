using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aportes.Server.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aporte",
                columns: table => new
                {
                    AporteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aporte", x => x.AporteId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposAportes",
                columns: table => new
                {
                    TipoAporteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Meta = table.Column<float>(type: "REAL", nullable: false),
                    Logrado = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposAportes", x => x.TipoAporteId);
                });

            migrationBuilder.CreateTable(
                name: "AporteDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoAporteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false),
                    AporteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AporteDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AporteDetalle_Aporte_AporteId",
                        column: x => x.AporteId,
                        principalTable: "Aporte",
                        principalColumn: "AporteId");
                    table.ForeignKey(
                        name: "FK_AporteDetalle_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AporteDetalle_TiposAportes_TipoAporteId",
                        column: x => x.TipoAporteId,
                        principalTable: "TiposAportes",
                        principalColumn: "TipoAporteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aporte",
                columns: new[] { "AporteId", "Concepto", "Fecha", "Monto", "PersonaId" },
                values: new object[,]
                {
                    { 1, "Pintura banco", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 200f, 1 },
                    { 2, "Reparacion Techo", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 500f, 2 }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 1, "Nay" },
                    { 2, "Jasson" }
                });

            migrationBuilder.InsertData(
                table: "TiposAportes",
                columns: new[] { "TipoAporteId", "Descripcion", "Logrado", "Meta" },
                values: new object[,]
                {
                    { 1, "Pintura Banco", 5000f, 10000f },
                    { 2, "Reparacion Techo", 10000f, 50000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AporteDetalle_AporteId",
                table: "AporteDetalle",
                column: "AporteId");

            migrationBuilder.CreateIndex(
                name: "IX_AporteDetalle_PersonaId",
                table: "AporteDetalle",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_AporteDetalle_TipoAporteId",
                table: "AporteDetalle",
                column: "TipoAporteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AporteDetalle");

            migrationBuilder.DropTable(
                name: "Aporte");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "TiposAportes");
        }
    }
}
