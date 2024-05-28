﻿// <auto-generated />
using System;
using Koton.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Koton.Entities.Migrations
{
    [DbContext(typeof(KotonDbContext))]
    partial class KotonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Koton.Entities.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<double>("CartTotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("ProductsId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Koton.Entities.Models.Categories", b =>
                {
                    b.Property<int>("CategoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriesId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriesId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Koton.Entities.Models.Customers", b =>
                {
                    b.Property<int>("CustomersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomersId"));

                    b.Property<string>("CustomerAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CustomerBirthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomersId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Koton.Entities.Models.OrderType", b =>
                {
                    b.Property<int>("OrderTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderTypeId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OrderTypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderTypeId");

                    b.HasIndex("OrdersId");

                    b.ToTable("OrderTypes");
                });

            modelBuilder.Entity("Koton.Entities.Models.Order_details", b =>
                {
                    b.Property<int>("Order_detailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_detailsId"));

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("RefundAmount")
                        .HasColumnType("float");

                    b.Property<string>("ReturnStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalesPrice")
                        .HasColumnType("float");

                    b.Property<double>("ShippingCost")
                        .HasColumnType("float");

                    b.Property<double>("TaxRate")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_detailsId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductsId");

                    b.ToTable("Order_detail");
                });

            modelBuilder.Entity("Koton.Entities.Models.Orders", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersId"));

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OrderAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderCargoCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderCurrency")
                        .HasColumnType("int");

                    b.Property<string>("OrderInvoiceAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderTotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrdersId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Koton.Entities.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentGateway")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Koton.Entities.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsId"));

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewsId")
                        .HasColumnType("int");

                    b.Property<double>("SalesPrice")
                        .HasColumnType("float");

                    b.Property<int?>("SizeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductsId");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("SizeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Koton.Entities.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewsId"));

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<double>("Ratings")
                        .HasColumnType("float");

                    b.Property<string>("ReviewsDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewsImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewsStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewsId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("ProductsId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Koton.Entities.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("SizeMeasure")
                        .HasColumnType("float");

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("deletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Koton.Entities.Models.Cart", b =>
                {
                    b.HasOne("Koton.Entities.Models.Customers", "Customer")
                        .WithMany("Carts")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koton.Entities.Models.Products", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koton.Entities.Models.OrderType", b =>
                {
                    b.HasOne("Koton.Entities.Models.Orders", "Orders")
                        .WithMany("OrderTypes")
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Koton.Entities.Models.Order_details", b =>
                {
                    b.HasOne("Koton.Entities.Models.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koton.Entities.Models.Products", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koton.Entities.Models.Orders", b =>
                {
                    b.HasOne("Koton.Entities.Models.Customers", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koton.Entities.Models.Payment", "Payments")
                        .WithMany("Order")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Koton.Entities.Models.Products", b =>
                {
                    b.HasOne("Koton.Entities.Models.Categories", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koton.Entities.Models.Size", "Sizes")
                        .WithMany("Product")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Sizes");
                });

            modelBuilder.Entity("Koton.Entities.Models.Reviews", b =>
                {
                    b.HasOne("Koton.Entities.Models.Customers", "Customer")
                        .WithMany("Review")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koton.Entities.Models.Products", "Product")
                        .WithMany("Review")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koton.Entities.Models.Categories", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koton.Entities.Models.Customers", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Order");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Koton.Entities.Models.Orders", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("OrderTypes");
                });

            modelBuilder.Entity("Koton.Entities.Models.Payment", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Koton.Entities.Models.Products", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderDetails");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Koton.Entities.Models.Size", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}