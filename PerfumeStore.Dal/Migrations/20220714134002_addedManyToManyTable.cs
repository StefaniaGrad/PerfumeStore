using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfumeStore.Dal.Migrations
{
    public partial class addedManyToManyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OptionValueVariant",
                columns: table => new
                {
                    OptionValueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionValueVariant", x => new { x.OptionValueId, x.VariantId });
                    table.ForeignKey(
                        name: "FK_OptionValueVariant_OptionValues_VariantId",
                        column: x => x.VariantId,
                        principalTable: "OptionValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OptionValueVariant_Variants_OptionValueId",
                        column: x => x.OptionValueId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OptionValueVariant_VariantId",
                table: "OptionValueVariant",
                column: "VariantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionValueVariant");
        }
    }
}
