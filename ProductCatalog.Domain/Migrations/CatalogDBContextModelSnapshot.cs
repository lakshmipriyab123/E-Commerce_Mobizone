﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalog.Domain.DataBase;

namespace ProductCatalog.Domain.Migrations
{
    [DbContext(typeof(CatalogDBContext))]
    partial class CatalogDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProductCatalog.Domain.Cart.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<int>("LookUpId")
                        .HasColumnType("int")
                        .HasColumnName("look_up_id");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("LookUpId");

                    b.HasIndex("UserId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Customers.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<long>("Contact")
                        .HasColumnType("bigInt")
                        .HasColumnName("contact");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Customers.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address_line");

                    b.Property<int>("Contact")
                        .HasColumnType("int")
                        .HasColumnName("contact");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("UserLocationId")
                        .HasColumnType("int")
                        .HasColumnName("user_location_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserLocationId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Customers.UserLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("postal_code");

                    b.HasKey("Id");

                    b.ToTable("UserLocation");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.CatalogOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<int>("LookUpId")
                        .HasColumnType("int")
                        .HasColumnName("look_up_id");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<int>("OrderDetailsId")
                        .HasColumnType("int")
                        .HasColumnName("order_details_id");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int>("product_id")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.HasKey("Id");

                    b.HasIndex("LookUpId");

                    b.HasIndex("OrderDetailsId");

                    b.HasIndex("ProductId");

                    b.ToTable("CatalogOrder");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at_utc");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("ModifiedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at_utc");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<int?>("PaymentDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int")
                        .HasColumnName("totalamount");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("paymentID")
                        .HasColumnType("int")
                        .HasColumnName("payment_id");

                    b.HasKey("Id");

                    b.HasIndex("PaymentDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<int?>("CatalogOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at_utc");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("ModifiedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at_utc");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modified_by");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("order_status");

                    b.HasKey("Id");

                    b.HasIndex("CatalogOrderId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.PaymentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<int?>("CatalogOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at_utc");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("ModifiedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at_utc");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("payment_status");

                    b.HasKey("Id");

                    b.HasIndex("CatalogOrderId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("Varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.LookUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("parent_id");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("LookUp");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "ProductType"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "ProductBrand"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "Color"
                        },
                        new
                        {
                            Id = 4,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "Storage"
                        },
                        new
                        {
                            Id = 5,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "SimType"
                        },
                        new
                        {
                            Id = 6,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "OperatingSystem"
                        },
                        new
                        {
                            Id = 7,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "ProcessorType"
                        },
                        new
                        {
                            Id = 8,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "ProcessorCore"
                        },
                        new
                        {
                            Id = 9,
                            CreatedOnUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 0,
                            name = "PrimaryCamera"
                        });
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<int>("AvailableStock")
                        .HasColumnType("int")
                        .HasColumnName("available_stock");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on_utc");

                    b.Property<DateTime>("DeletedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_on_utc");

                    b.Property<string>("IsActive")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("is_active");

                    b.Property<int>("LookUpId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedOnUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_on_utc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int")
                        .HasColumnName("specification_id");

                    b.HasKey("Id");

                    b.HasIndex("LookUpId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAtUST")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at_ust");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<string>("DisplaySize")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("display_size");

                    b.Property<string>("DisplayType")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("display_type");

                    b.Property<string>("HybridSlot")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("hybrid_slot");

                    b.Property<DateTime>("ModifiedAtUST")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at_ust");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<string>("OsSupported")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("os_supported");

                    b.Property<string>("OtherFeatures")
                        .HasColumnType("Varchar(500)")
                        .HasColumnName("other_features");

                    b.Property<string>("Resolution")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("resolution");

                    b.Property<string>("ResolutionType")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("resolution_type");

                    b.Property<string>("SimType")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("sim_type");

                    b.Property<string>("SystemRequirement")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("system_requirement");

                    b.Property<string>("Version")
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Role.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at_utc");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("ModifiedAtUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_at_utc");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified_by");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("roles");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Cart.CartItem", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Products.LookUp", "LookUp")
                        .WithMany()
                        .HasForeignKey("LookUpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductCatalog.Domain.Customers.User", "User")
                        .WithMany("CartItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LookUp");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Customers.UserAddress", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Customers.User", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductCatalog.Domain.Customers.UserLocation", "UserLocation")
                        .WithMany()
                        .HasForeignKey("UserLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserLocation");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.CatalogOrder", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Products.LookUp", "LookUp")
                        .WithMany()
                        .HasForeignKey("LookUpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductCatalog.Domain.Order.OrderDetails", "OrderDetails")
                        .WithMany()
                        .HasForeignKey("OrderDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductCatalog.Domain.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("LookUp");

                    b.Navigation("OrderDetails");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.OrderDetails", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Order.PaymentDetails", "PaymentDetails")
                        .WithMany()
                        .HasForeignKey("PaymentDetailsId");

                    b.HasOne("ProductCatalog.Domain.Customers.User", "Users")
                        .WithMany("OrderDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentDetails");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.OrderStatus", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Order.CatalogOrder", "CatalogOrder")
                        .WithMany()
                        .HasForeignKey("CatalogOrderId");

                    b.Navigation("CatalogOrder");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Order.PaymentDetails", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Order.CatalogOrder", "CatalogOrder")
                        .WithMany()
                        .HasForeignKey("CatalogOrderId");

                    b.Navigation("CatalogOrder");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.Image", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Products.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.Product", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Products.LookUp", "LookUp")
                        .WithMany()
                        .HasForeignKey("LookUpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductCatalog.Domain.Products.Specification", "Specification")
                        .WithMany()
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LookUp");

                    b.Navigation("Specification");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Role.Roles", b =>
                {
                    b.HasOne("ProductCatalog.Domain.Customers.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Customers.User", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderDetails");

                    b.Navigation("UserAddresses");
                });

            modelBuilder.Entity("ProductCatalog.Domain.Products.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
