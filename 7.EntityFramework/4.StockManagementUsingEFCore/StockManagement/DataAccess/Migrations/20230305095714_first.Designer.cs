﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(StockManagementContext))]
    [Migration("20230305095714_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.PurchaseDetails", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PurchaseQty")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId");

                    b.ToTable("PurchaseDetailData");
                });

            modelBuilder.Entity("DataAccess.Models.SaleDetails", b =>
                {
                    b.Property<int>("SalesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesID"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SalesQty")
                        .HasColumnType("int");

                    b.HasKey("SalesID");

                    b.ToTable("SalesData");
                });
#pragma warning restore 612, 618
        }
    }
}
