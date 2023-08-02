using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigNva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persona_Provincias_ProvinciaIdProvincia",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_TipoPersonas_TipoPersonaIdTipoPersona",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaProductos_Productos_ProductoId",
                table: "PersonaProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_marca_MarcaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_region_RegionIdRegion",
                table: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_persona_ProvinciaIdProvincia",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "IX_persona_TipoPersonaIdTipoPersona",
                table: "persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPersonas",
                table: "TipoPersonas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Provincias_RegionIdRegion",
                table: "Provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProvinciaIdProvincia",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "TipoPersonaIdTipoPersona",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "RegionIdRegion",
                table: "Provincias");

            migrationBuilder.RenameTable(
                name: "TipoPersonas",
                newName: "tipopersona");

            migrationBuilder.RenameTable(
                name: "Provincias",
                newName: "provincia");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "producto");

            migrationBuilder.RenameColumn(
                name: "IdRegion",
                table: "region",
                newName: "IdCod");

            migrationBuilder.RenameColumn(
                name: "IdPais",
                table: "pais",
                newName: "IdCod");

            migrationBuilder.RenameColumn(
                name: "IdTipoPersona",
                table: "tipopersona",
                newName: "IdCod");

            migrationBuilder.RenameColumn(
                name: "IdProvincia",
                table: "provincia",
                newName: "IdCod");

            migrationBuilder.RenameColumn(
                name: "IdProducto",
                table: "producto",
                newName: "IdCod");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_MarcaId",
                table: "producto",
                newName: "IX_producto_MarcaId");

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "NombrePersona",
                keyValue: null,
                column: "NombrePersona",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePersona",
                table: "persona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "ApellidoPersona",
                keyValue: null,
                column: "ApellidoPersona",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoPersona",
                table: "persona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tipopersona",
                keyColumn: "Descripcion",
                keyValue: null,
                column: "Descripcion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tipopersona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "provincia",
                keyColumn: "Descripcion",
                keyValue: null,
                column: "Descripcion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "provincia",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "producto",
                keyColumn: "RefProducto",
                keyValue: null,
                column: "RefProducto",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "RefProducto",
                table: "producto",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "producto",
                keyColumn: "DescripcionProducto",
                keyValue: null,
                column: "DescripcionProducto",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionProducto",
                table: "producto",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipopersona",
                table: "tipopersona",
                column: "IdCod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_provincia",
                table: "provincia",
                column: "IdCod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producto",
                table: "producto",
                column: "IdCod");

            migrationBuilder.CreateIndex(
                name: "IX_persona_ProvId",
                table: "persona",
                column: "ProvId");

            migrationBuilder.CreateIndex(
                name: "IX_persona_TipoPerId",
                table: "persona",
                column: "TipoPerId");

            migrationBuilder.CreateIndex(
                name: "IX_provincia_RegId",
                table: "provincia",
                column: "RegId");

            migrationBuilder.AddForeignKey(
                name: "FK_persona_provincia_ProvId",
                table: "persona",
                column: "ProvId",
                principalTable: "provincia",
                principalColumn: "IdCod",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_tipopersona_TipoPerId",
                table: "persona",
                column: "TipoPerId",
                principalTable: "tipopersona",
                principalColumn: "IdCod",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaProductos_producto_ProductoId",
                table: "PersonaProductos",
                column: "ProductoId",
                principalTable: "producto",
                principalColumn: "IdCod",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_producto_marca_MarcaId",
                table: "producto",
                column: "MarcaId",
                principalTable: "marca",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_provincia_region_RegId",
                table: "provincia",
                column: "RegId",
                principalTable: "region",
                principalColumn: "IdCod",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persona_provincia_ProvId",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_tipopersona_TipoPerId",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaProductos_producto_ProductoId",
                table: "PersonaProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_producto_marca_MarcaId",
                table: "producto");

            migrationBuilder.DropForeignKey(
                name: "FK_provincia_region_RegId",
                table: "provincia");

            migrationBuilder.DropIndex(
                name: "IX_persona_ProvId",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "IX_persona_TipoPerId",
                table: "persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipopersona",
                table: "tipopersona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provincia",
                table: "provincia");

            migrationBuilder.DropIndex(
                name: "IX_provincia_RegId",
                table: "provincia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto",
                table: "producto");

            migrationBuilder.RenameTable(
                name: "tipopersona",
                newName: "TipoPersonas");

            migrationBuilder.RenameTable(
                name: "provincia",
                newName: "Provincias");

            migrationBuilder.RenameTable(
                name: "producto",
                newName: "Productos");

            migrationBuilder.RenameColumn(
                name: "IdCod",
                table: "region",
                newName: "IdRegion");

            migrationBuilder.RenameColumn(
                name: "IdCod",
                table: "pais",
                newName: "IdPais");

            migrationBuilder.RenameColumn(
                name: "IdCod",
                table: "TipoPersonas",
                newName: "IdTipoPersona");

            migrationBuilder.RenameColumn(
                name: "IdCod",
                table: "Provincias",
                newName: "IdProvincia");

            migrationBuilder.RenameColumn(
                name: "IdCod",
                table: "Productos",
                newName: "IdProducto");

            migrationBuilder.RenameIndex(
                name: "IX_producto_MarcaId",
                table: "Productos",
                newName: "IX_Productos_MarcaId");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePersona",
                table: "persona",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoPersona",
                table: "persona",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaIdProvincia",
                table: "persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPersonaIdTipoPersona",
                table: "persona",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Provincias",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "RegionIdRegion",
                table: "Provincias",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefProducto",
                table: "Productos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionProducto",
                table: "Productos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPersonas",
                table: "TipoPersonas",
                column: "IdTipoPersona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "IdProvincia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_persona_ProvinciaIdProvincia",
                table: "persona",
                column: "ProvinciaIdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_persona_TipoPersonaIdTipoPersona",
                table: "persona",
                column: "TipoPersonaIdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_RegionIdRegion",
                table: "Provincias",
                column: "RegionIdRegion");

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
                name: "FK_PersonaProductos_Productos_ProductoId",
                table: "PersonaProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_marca_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "marca",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_region_RegionIdRegion",
                table: "Provincias",
                column: "RegionIdRegion",
                principalTable: "region",
                principalColumn: "IdRegion");
        }
    }
}
