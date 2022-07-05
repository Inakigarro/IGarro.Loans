using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prestamos.Loans.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Loans");

            migrationBuilder.CreateTable(
                name: "Loans",
                schema: "Loans",
                columns: table => new
                {
                    CorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerCorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.CorrelationId);
                });

            migrationBuilder.CreateTable(
                name: "LoanLines",
                schema: "Loans",
                columns: table => new
                {
                    CorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    MaterialCorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoanCorrelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanLines", x => x.CorrelationId);
                    table.ForeignKey(
                        name: "FK_LoanLines_Loans_LoanCorrelationId",
                        column: x => x.LoanCorrelationId,
                        principalSchema: "Loans",
                        principalTable: "Loans",
                        principalColumn: "CorrelationId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanLines_LoanCorrelationId",
                schema: "Loans",
                table: "LoanLines",
                column: "LoanCorrelationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanLines",
                schema: "Loans");

            migrationBuilder.DropTable(
                name: "Loans",
                schema: "Loans");
        }
    }
}
