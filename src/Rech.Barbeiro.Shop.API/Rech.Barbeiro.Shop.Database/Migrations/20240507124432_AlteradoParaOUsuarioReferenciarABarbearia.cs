using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rech.Barbeiro.Shop.Database.Migrations
{
    /// <inheritdoc />
    public partial class AlteradoParaOUsuarioReferenciarABarbearia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Barbearias_UsuarioId",
                table: "Barbearias");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Barbearias");

            migrationBuilder.AddColumn<Guid>(
                name: "BarbeariaId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BarbeariaId",
                table: "AspNetUsers",
                column: "BarbeariaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Barbearias_BarbeariaId",
                table: "AspNetUsers",
                column: "BarbeariaId",
                principalTable: "Barbearias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Barbearias_BarbeariaId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BarbeariaId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BarbeariaId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Barbearias",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Barbearias_UsuarioId",
                table: "Barbearias",
                column: "UsuarioId");
        }
    }
}
