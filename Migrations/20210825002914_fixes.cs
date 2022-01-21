using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarjetasApp.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Persona_IdTarjeta",
                table: "Tarjeta");

            migrationBuilder.AlterColumn<int>(
                name: "IdTarjeta",
                table: "Tarjeta",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Tarjeta",
                keyColumn: "IdTarjeta",
                keyValue: 1,
                column: "Vencimiento",
                value: new DateTime(2021, 8, 24, 21, 29, 14, 115, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_IdPersona",
                table: "Tarjeta",
                column: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Persona_IdPersona",
                table: "Tarjeta",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Persona_IdPersona",
                table: "Tarjeta");

            migrationBuilder.DropIndex(
                name: "IX_Tarjeta_IdPersona",
                table: "Tarjeta");

            migrationBuilder.AlterColumn<int>(
                name: "IdTarjeta",
                table: "Tarjeta",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Tarjeta",
                keyColumn: "IdTarjeta",
                keyValue: 1,
                column: "Vencimiento",
                value: new DateTime(2021, 8, 24, 20, 6, 57, 721, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Persona_IdTarjeta",
                table: "Tarjeta",
                column: "IdTarjeta",
                principalTable: "Persona",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
