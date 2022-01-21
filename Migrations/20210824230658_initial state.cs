using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarjetasApp.Migrations
{
    public partial class initialstate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    IdTarjeta = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Titular = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdPersona = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Limite = table.Column<long>(type: "bigint", nullable: false),
                    Tasa = table.Column<double>(type: "float", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Marca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.IdTarjeta);
                    table.ForeignKey(
                        name: "FK_Tarjeta_Persona_IdTarjeta",
                        column: x => x.IdTarjeta,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "IdPersona", "Apellido", "DNI", "Direccion", "Nombre" },
                values: new object[] { 1, "Asis", "36897458", "Osvaldo cruz", "Alex" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "Nombre", "NombreUsuario", "Password" },
                values: new object[] { 1, "Alex", "Alex", "Asis" });

            migrationBuilder.InsertData(
                table: "Tarjeta",
                columns: new[] { "IdTarjeta", "IdPersona", "Limite", "Marca", "Nombre", "Numero", "Tasa", "Titular", "Vencimiento" },
                values: new object[] { 1, 1, 100000L, 2, "Alex", "00000000", 0.80000000000000004, "Alex", new DateTime(2021, 8, 24, 20, 6, 57, 721, DateTimeKind.Local).AddTicks(3744) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjeta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
