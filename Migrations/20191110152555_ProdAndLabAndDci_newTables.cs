using Microsoft.EntityFrameworkCore.Migrations;

namespace INPRO.API.Migrations
{
    public partial class ProdAndLabAndDci_newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DciCode = table.Column<string>(nullable: true),
                    DciName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laboratory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaboratotyCode = table.Column<string>(nullable: true),
                    LaboratoryName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    DE = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    FormId = table.Column<string>(nullable: true),
                    Dosage = table.Column<string>(nullable: true),
                    Conditioning = table.Column<string>(nullable: true),
                    Imported = table.Column<string>(nullable: true),
                    Refundable = table.Column<string>(nullable: true),
                    Psychotropic = table.Column<string>(nullable: true),
                    Thermolabile = table.Column<string>(nullable: true),
                    ProductClass = table.Column<string>(nullable: true),
                    TherapeuticClass = table.Column<string>(nullable: true),
                    PharmacologicalClass = table.Column<string>(nullable: true),
                    Removed = table.Column<string>(nullable: true),
                    Availible = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<string>(nullable: true),
                    PPA = table.Column<string>(nullable: true),
                    ReferencePrice = table.Column<decimal>(nullable: false),
                    SG = table.Column<string>(nullable: true),
                    LaboratoryId = table.Column<int>(nullable: false),
                    LaboratoryName = table.Column<string>(nullable: true),
                    DciId = table.Column<int>(nullable: false),
                    Dci = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Dci_DciId",
                        column: x => x.DciId,
                        principalTable: "Dci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Laboratory_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "Laboratory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_DciId",
                table: "Product",
                column: "DciId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_LaboratoryId",
                table: "Product",
                column: "LaboratoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Dci");

            migrationBuilder.DropTable(
                name: "Laboratory");
        }
    }
}
