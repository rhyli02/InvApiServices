﻿// <auto-generated />
using System;
using InvApiServices.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvApiServices.Migrations
{
    [DbContext(typeof(InvDBContext))]
    partial class InvDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("InvApiServices.Models.Context.ApprovalAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApprovalLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApprovalType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApproverId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApprovalAssignments");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.ApprovalTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ApprovalLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApprovalType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApproverId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApprovalTransactions");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentTerms")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.GoodReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActualReceived")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderConvertion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderQty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrderUnit")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("GoodReceipts");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderUnit")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Barcode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bundle")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("BundlePrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("InStock")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastDateUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SKU")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sold")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Shipment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("TEXT");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Terms")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Vat")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.SalesMasterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AgentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApprovalStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DiscountAmt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Tax")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalAmt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Vat")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SalesMasterDatas");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.SalesMasterDataItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bundle")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SKU")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SalesMasterDataItems");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.Shipments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Shipment")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactDetails")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentTerms")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TIN")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("InvApiServices.Models.Context.Terms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientAccount")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Term")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Terms");
                });
#pragma warning restore 612, 618
        }
    }
}
