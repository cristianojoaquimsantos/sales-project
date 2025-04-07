﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesDemon.Infra.Data.Context;

#nullable disable

namespace SalesDemon.Infra.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesDemo.Domain.Model.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptionCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NameCategory");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PK_Category");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ProductName");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SubCategoryId");

                    b.Property<decimal>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m)
                        .HasColumnName("UnitPrice");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PK_Product");

                    b.HasIndex("SubCategoryId", "CategoryId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateSale")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalSale")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "StoreId", "SellerId")
                        .HasName("PK_Sale");

                    b.HasIndex("SellerId", "StoreId");

                    b.ToTable("Sale", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.SaleProducts", b =>
                {
                    b.Property<Guid>("SaleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SaleDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SaleSellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SaleStoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SaleId", "ProductId")
                        .HasName("PK_SaleProducts");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId", "SaleStoreId", "SaleSellerId");

                    b.ToTable("SaleProducts", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Seller", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("SellerName");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "StoreId")
                        .HasName("PK_Seller");

                    b.HasIndex("StoreId");

                    b.ToTable("Seller", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("City");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("District");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("StoreName");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ZipCode");

                    b.HasKey("Id")
                        .HasName("PK_Store");

                    b.ToTable("Store", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptionSubCategory")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("DescriptionSubCategory");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameSubCategory")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NameSubCategory");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "CategoryId")
                        .HasName("PK_SubCategory");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory", (string)null);
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Product", b =>
                {
                    b.HasOne("SalesDemo.Domain.Model.SubCategory", "SubCategory")
                        .WithMany("Product")
                        .HasForeignKey("SubCategoryId", "CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Sale", b =>
                {
                    b.HasOne("SalesDemo.Domain.Model.Seller", "Seller")
                        .WithMany("Sale")
                        .HasForeignKey("SellerId", "StoreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.SaleProducts", b =>
                {
                    b.HasOne("SalesDemo.Domain.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDemo.Domain.Model.Sale", "Sale")
                        .WithMany("SaleProduct")
                        .HasForeignKey("SaleId", "SaleStoreId", "SaleSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Seller", b =>
                {
                    b.HasOne("SalesDemo.Domain.Model.Store", "Store")
                        .WithMany("Sellers")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.SubCategory", b =>
                {
                    b.HasOne("SalesDemo.Domain.Model.Category", "Category")
                        .WithMany("SubCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Category", b =>
                {
                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Sale", b =>
                {
                    b.Navigation("SaleProduct");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Seller", b =>
                {
                    b.Navigation("Sale");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.Store", b =>
                {
                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("SalesDemo.Domain.Model.SubCategory", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
