using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koton.Entities.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Review_ReviewsId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Review_ReviewsId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ReviewsId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ReviewsId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ReviewsId",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewsId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomersId",
                table: "Review",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductsId",
                table: "Review",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_CustomersId",
                table: "Review",
                column: "CustomersId",
                principalTable: "Customer",
                principalColumn: "CustomersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Product_ProductsId",
                table: "Review",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_CustomersId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Product_ProductsId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_CustomersId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_ProductsId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewsId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewsId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ReviewsId",
                table: "Product",
                column: "ReviewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ReviewsId",
                table: "Customer",
                column: "ReviewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Review_ReviewsId",
                table: "Customer",
                column: "ReviewsId",
                principalTable: "Review",
                principalColumn: "ReviewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Review_ReviewsId",
                table: "Product",
                column: "ReviewsId",
                principalTable: "Review",
                principalColumn: "ReviewsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
