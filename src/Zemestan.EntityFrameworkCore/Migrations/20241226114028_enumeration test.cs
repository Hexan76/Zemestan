using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zemestan.Migrations
{
    /// <inheritdoc />
    public partial class enumerationtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enumeration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClusterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enumeration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnumerationTranslate",
                columns: table => new
                {
                    Language = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnumerationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumerationTranslate", x => new { x.Language, x.EnumerationId });
                    table.ForeignKey(
                        name: "FK_EnumerationTranslate_Enumeration_EnumerationId",
                        column: x => x.EnumerationId,
                        principalTable: "Enumeration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnumerationTranslate_EnumerationId",
                table: "EnumerationTranslate",
                column: "EnumerationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnumerationTranslate");

            migrationBuilder.DropTable(
                name: "Enumeration");
        }
    }
}
