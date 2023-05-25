﻿// <auto-generated />
using BestRestaurants.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BestRestaurants.Migrations
{
    [DbContext(typeof(BestRestaurantsContext))]
    [Migration("20230525180229_RequireCuisineType")]
    partial class RequireCuisineType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BestRestaurants.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CuisineId");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("BestRestaurants.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CuisineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RestaurantId");

                    b.HasIndex("CuisineId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("BestRestaurants.Models.RestaurantTag", b =>
                {
                    b.Property<int>("RestaurantTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantTagId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TagId");

                    b.ToTable("RestaurantTags");
                });

            modelBuilder.Entity("BestRestaurants.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BestRestaurants.Models.Restaurant", b =>
                {
                    b.HasOne("BestRestaurants.Models.Cuisine", "Cuisine")
                        .WithMany("Restaurants")
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");
                });

            modelBuilder.Entity("BestRestaurants.Models.RestaurantTag", b =>
                {
                    b.HasOne("BestRestaurants.Models.Restaurant", "Restaurant")
                        .WithMany("JoinEntities")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BestRestaurants.Models.Tag", "Tag")
                        .WithMany("JoinEntities")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("BestRestaurants.Models.Cuisine", b =>
                {
                    b.Navigation("Restaurants");
                });

            modelBuilder.Entity("BestRestaurants.Models.Restaurant", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("BestRestaurants.Models.Tag", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
