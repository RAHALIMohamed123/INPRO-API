using Microsoft.EntityFrameworkCore.Migrations;

namespace INPRO.API.Migrations
{
    public partial class updateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Users_UserId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Dci_DciId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Laboratory_LaboratoryId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laboratory",
                table: "Laboratory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dci",
                table: "Dci");

            migrationBuilder.DropColumn(
                name: "Dci",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LaboratoryName",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Dci");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "Laboratory",
                newName: "Laboratories");

            migrationBuilder.RenameTable(
                name: "Dci",
                newName: "Dcis");

            migrationBuilder.RenameIndex(
                name: "IX_Product_LaboratoryId",
                table: "Products",
                newName: "IX_Products_LaboratoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_DciId",
                table: "Products",
                newName: "IX_Products_DciId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_UserId",
                table: "Photos",
                newName: "IX_Photos_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laboratories",
                table: "Laboratories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dcis",
                table: "Dcis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Dcis_DciId",
                table: "Products",
                column: "DciId",
                principalTable: "Dcis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Laboratories_LaboratoryId",
                table: "Products",
                column: "LaboratoryId",
                principalTable: "Laboratories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Dcis_DciId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Laboratories_LaboratoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laboratories",
                table: "Laboratories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dcis",
                table: "Dcis");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameTable(
                name: "Laboratories",
                newName: "Laboratory");

            migrationBuilder.RenameTable(
                name: "Dcis",
                newName: "Dci");

            migrationBuilder.RenameIndex(
                name: "IX_Products_LaboratoryId",
                table: "Product",
                newName: "IX_Product_LaboratoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_DciId",
                table: "Product",
                newName: "IX_Product_DciId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_UserId",
                table: "Photo",
                newName: "IX_Photo_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Dci",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LaboratoryName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Laboratory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Dci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laboratory",
                table: "Laboratory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dci",
                table: "Dci",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Users_UserId",
                table: "Photo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Dci_DciId",
                table: "Product",
                column: "DciId",
                principalTable: "Dci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Laboratory_LaboratoryId",
                table: "Product",
                column: "LaboratoryId",
                principalTable: "Laboratory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
