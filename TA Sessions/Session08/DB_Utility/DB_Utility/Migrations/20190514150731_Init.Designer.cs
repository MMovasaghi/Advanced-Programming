﻿// <auto-generated />
using System;
using DB_Utility.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB_Utility.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20190514150731_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB_Utility.Models.LikeProduct", b =>
                {
                    b.Property<int>("LikeProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("LikeProductId");

                    b.ToTable("LikeProducts");
                });

            modelBuilder.Entity("DB_Utility.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("likeProductsLikeProductId");

                    b.HasKey("PersonId");

                    b.HasIndex("likeProductsLikeProductId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DB_Utility.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LikeProductId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("NumberOfExsistance");

                    b.Property<int?>("ProductDateId");

                    b.Property<string>("SerialNumber")
                        .IsRequired();

                    b.Property<int?>("ShoppingCardId");

                    b.HasKey("ProductId");

                    b.HasIndex("LikeProductId");

                    b.HasIndex("ProductDateId");

                    b.HasIndex("ShoppingCardId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DB_Utility.Models.ProductDate", b =>
                {
                    b.Property<int>("ProductDateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("E_Date");

                    b.Property<DateTime>("P_Date");

                    b.HasKey("ProductDateId");

                    b.ToTable("ProductDates");
                });

            modelBuilder.Entity("DB_Utility.Models.ShoppingCard", b =>
                {
                    b.Property<int>("ShoppingCardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("personid");

                    b.HasKey("ShoppingCardId");

                    b.HasIndex("personid")
                        .IsUnique();

                    b.ToTable("ShoppingCards");
                });

            modelBuilder.Entity("DB_Utility.Models.Person", b =>
                {
                    b.HasOne("DB_Utility.Models.LikeProduct", "likeProducts")
                        .WithMany()
                        .HasForeignKey("likeProductsLikeProductId");
                });

            modelBuilder.Entity("DB_Utility.Models.Product", b =>
                {
                    b.HasOne("DB_Utility.Models.LikeProduct")
                        .WithMany("products")
                        .HasForeignKey("LikeProductId");

                    b.HasOne("DB_Utility.Models.ProductDate", "productDate")
                        .WithMany()
                        .HasForeignKey("ProductDateId");

                    b.HasOne("DB_Utility.Models.ShoppingCard")
                        .WithMany("products")
                        .HasForeignKey("ShoppingCardId");
                });

            modelBuilder.Entity("DB_Utility.Models.ShoppingCard", b =>
                {
                    b.HasOne("DB_Utility.Models.Person")
                        .WithOne("shoppingCard")
                        .HasForeignKey("DB_Utility.Models.ShoppingCard", "personid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}