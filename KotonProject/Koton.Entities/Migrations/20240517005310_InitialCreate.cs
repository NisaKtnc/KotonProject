using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koton.Entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentGateway = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    Ratings = table.Column<double>(type: "float", nullable: false),
                    ReviewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewsStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewsImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewsId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeMeasure = table.Column<double>(type: "float", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewsId = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomersId);
                    table.ForeignKey(
                        name: "FK_Customer_Review_ReviewsId",
                        column: x => x.ReviewsId,
                        principalTable: "Review",
                        principalColumn: "ReviewsId");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewsId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductStock = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPrice = table.Column<double>(type: "float", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductsId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "CategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Review_ReviewsId",
                        column: x => x.ReviewsId,
                        principalTable: "Review",
                        principalColumn: "ReviewsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTotalPrice = table.Column<double>(type: "float", nullable: false),
                    OrderCargoCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    OrderInvoiceAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderCurrency = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrdersId);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customer",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartTotalPrice = table.Column<double>(type: "float", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_Customer_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customer",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_detail",
                columns: table => new
                {
                    Order_detailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    ShippingCost = table.Column<double>(type: "float", nullable: false),
                    ReturnStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefundAmount = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPrice = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    TaxRate = table.Column<double>(type: "float", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_detail", x => x.Order_detailsId);
                    table.ForeignKey(
                        name: "FK_Order_detail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_detail_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    OrderTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    OrderTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.OrderTypeId);
                    table.ForeignKey(
                        name: "FK_OrderTypes_Order_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Order",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomersId",
                table: "Carts",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductsId",
                table: "Carts",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ReviewsId",
                table: "Customer",
                column: "ReviewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomersId",
                table: "Order",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId",
                table: "Order",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_detail_OrderId",
                table: "Order_detail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_detail_ProductsId",
                table: "Order_detail",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTypes_OrdersId",
                table: "OrderTypes",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoriesId",
                table: "Product",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ReviewsId",
                table: "Product",
                column: "ReviewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SizeId",
                table: "Product",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Order_detail");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
