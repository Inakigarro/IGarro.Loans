using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prestamos.Materials.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Materials");

            migrationBuilder.CreateTable(
                name: "MaterialTypes",
                schema: "Materials",
                columns: table => new
                {
                    CorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTypes", x => x.CorrelationId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                schema: "Materials",
                columns: table => new
                {
                    CorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeCorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.CorrelationId);
                    table.ForeignKey(
                        name: "FK_Materials_MaterialTypes_TypeCorrelationId",
                        column: x => x.TypeCorrelationId,
                        principalSchema: "Materials",
                        principalTable: "MaterialTypes",
                        principalColumn: "CorrelationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_TypeCorrelationId",
                schema: "Materials",
                table: "Materials",
                column: "TypeCorrelationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials",
                schema: "Materials");

            migrationBuilder.DropTable(
                name: "MaterialTypes",
                schema: "Materials");
        }
    }
}
