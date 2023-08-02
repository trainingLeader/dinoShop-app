using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationCreateV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonaProductos_Personas_PersonaId",
                table: "PersonaProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Provincias_ProvinciaIdProvincia",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_TipoPersonas_TipoPersonaIdTipoPersona",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "persona");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_TipoPersonaIdTipoPersona",
                table: "persona",
                newName: "IX_persona_TipoPersonaIdTipoPersona");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_ProvinciaIdProvincia",
                table: "persona",
                newName: "IX_persona_ProvinciaIdProvincia");

            migrationBuilder.AddColumn<string>(
                name: "PersonaIdPersona",
                table: "PersonaProductos",
                type: "varchar(12)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersona",
                table: "persona",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_persona",
                table: "persona",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaProductos_PersonaIdPersona",
                table: "PersonaProductos",
                column: "PersonaIdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_persona_Provincias_ProvinciaIdProvincia",
                table: "persona",
                column: "ProvinciaIdProvincia",
                principalTable: "Provincias",
                principalColumn: "IdProvincia");

            migrationBuilder.AddForeignKey(
                name: "FK_persona_TipoPersonas_TipoPersonaIdTipoPersona",
                table: "persona",
                column: "TipoPersonaIdTipoPersona",
                principalTable: "TipoPersonas",
                principalColumn: "IdTipoPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaProductos_persona_PersonaIdPersona",
                table: "PersonaProductos",
                column: "PersonaIdPersona",
                principalTable: "persona",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persona_Provincias_ProvinciaIdProvincia",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_TipoPersonas_TipoPersonaIdTipoPersona",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaProductos_persona_PersonaIdPersona",
                table: "PersonaProductos");

            migrationBuilder.DropIndex(
                name: "IX_PersonaProductos_PersonaIdPersona",
                table: "PersonaProductos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persona",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "PersonaIdPersona",
                table: "PersonaProductos");

            migrationBuilder.RenameTable(
                name: "persona",
                newName: "Personas");

            migrationBuilder.RenameIndex(
                name: "IX_persona_TipoPersonaIdTipoPersona",
                table: "Personas",
                newName: "IX_Personas_TipoPersonaIdTipoPersona");

            migrationBuilder.RenameIndex(
                name: "IX_persona_ProvinciaIdProvincia",
                table: "Personas",
                newName: "IX_Personas_ProvinciaIdProvincia");

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "Personas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldMaxLength: 12)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaProductos_Personas_PersonaId",
                table: "PersonaProductos",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Provincias_ProvinciaIdProvincia",
                table: "Personas",
                column: "ProvinciaIdProvincia",
                principalTable: "Provincias",
                principalColumn: "IdProvincia");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_TipoPersonas_TipoPersonaIdTipoPersona",
                table: "Personas",
                column: "TipoPersonaIdTipoPersona",
                principalTable: "TipoPersonas",
                principalColumn: "IdTipoPersona");
        }
    }
}
