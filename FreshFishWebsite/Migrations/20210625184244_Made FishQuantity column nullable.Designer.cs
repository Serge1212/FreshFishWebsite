﻿// <auto-generated />
using System;
using FreshFishWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FreshFishWebsite.Migrations
{
    [DbContext(typeof(FreshFishDbContext))]
    [Migration("20210625184244_Made FishQuantity column nullable")]
    partial class MadeFishQuantitycolumnnullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("FreshFishWebsite.Models.Feeding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DateTimeFed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PoolId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.ToTable("Feedings");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<bool>("IsOrderAssigned")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("DriverId")
                        .HasColumnType("text");

                    b.Property<bool>("IsAssigned")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("boolean");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("StorageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("OrderId");

                    b.HasIndex("StorageId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Pool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DateTimeFeedingExpired")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("FishQuantly")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("integer");

                    b.Property<bool?>("IsFishFed")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("boolean");

                    b.Property<int>("MaxProductsKg")
                        .HasColumnType("integer");

                    b.Property<int>("PoolNumber")
                        .HasColumnType("integer");

                    b.Property<int>("RemainingSpaceForProducts")
                        .HasColumnType("integer");

                    b.Property<int>("StorageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("Pools");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.PoolState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DataAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Nitrogen")
                        .HasColumnType("double precision");

                    b.Property<int>("PoolId")
                        .HasColumnType("integer");

                    b.Property<double>("Temperature")
                        .HasColumnType("double precision");

                    b.Property<double>("WaterLevel")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.ToTable("PoolStates");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Calories")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<bool>("IsSold")
                        .HasColumnType("boolean");

                    b.Property<double>("PricePerKg")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<int>("QuantityKg")
                        .HasColumnType("integer");

                    b.Property<int>("RemainingQuantityKg")
                        .HasColumnType("integer");

                    b.Property<int>("StorageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ProductInPool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("PoolId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalProductQuantityKg")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsInPool");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ShoppingCartProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartProducts");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("StorageAdminId")
                        .HasColumnType("text");

                    b.Property<int>("StorageNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StorageAdminId")
                        .IsUnique();

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Usersurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Driver", b =>
                {
                    b.HasBaseType("FreshFishWebsite.Models.User");

                    b.Property<bool>("IsDelivering")
                        .HasColumnType("boolean");

                    b.Property<int>("OrderItemsId")
                        .HasColumnType("integer");

                    b.Property<int?>("StorageId")
                        .HasColumnType("integer");

                    b.HasIndex("StorageId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.StorageAdmin", b =>
                {
                    b.HasBaseType("FreshFishWebsite.Models.User");

                    b.ToTable("StorageAdmins");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Feeding", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Pool", "Pool")
                        .WithMany("Feeding")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Order", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.OrderItems", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Driver", "Driver")
                        .WithMany("OrderItems")
                        .HasForeignKey("DriverId");

                    b.HasOne("FreshFishWebsite.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshFishWebsite.Models.Storage", "Storage")
                        .WithMany("OrderItems")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Order");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Pool", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Storage", "Storage")
                        .WithMany("Pools")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.PoolState", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Pool", "Pool")
                        .WithMany("PoolStates")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Product", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Storage", "Storage")
                        .WithMany("Products")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ProductInPool", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Pool", "Pool")
                        .WithMany("ProductsInPool")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshFishWebsite.Models.Product", "Product")
                        .WithMany("ProductsInPool")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pool");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ShoppingCart", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", "User")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("FreshFishWebsite.Models.ShoppingCart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ShoppingCartProduct", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.HasOne("FreshFishWebsite.Models.Product", "Product")
                        .WithMany("ShoppingCartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshFishWebsite.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("Products")
                        .HasForeignKey("ShoppingCartId");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Storage", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.StorageAdmin", "StorageAdmin")
                        .WithOne("Storage")
                        .HasForeignKey("FreshFishWebsite.Models.Storage", "StorageAdminId");

                    b.Navigation("StorageAdmin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshFishWebsite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Driver", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", null)
                        .WithOne()
                        .HasForeignKey("FreshFishWebsite.Models.Driver", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshFishWebsite.Models.Storage", "Storage")
                        .WithMany("Drivers")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.StorageAdmin", b =>
                {
                    b.HasOne("FreshFishWebsite.Models.User", null)
                        .WithOne()
                        .HasForeignKey("FreshFishWebsite.Models.StorageAdmin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Pool", b =>
                {
                    b.Navigation("Feeding");

                    b.Navigation("PoolStates");

                    b.Navigation("ProductsInPool");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Product", b =>
                {
                    b.Navigation("ProductsInPool");

                    b.Navigation("ShoppingCartProducts");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.ShoppingCart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Storage", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("OrderItems");

                    b.Navigation("Pools");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.Driver", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FreshFishWebsite.Models.StorageAdmin", b =>
                {
                    b.Navigation("Storage");
                });
#pragma warning restore 612, 618
        }
    }
}
