// <auto-generated />
using System;
using CableProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CableProvider.Migrations
{
    [DbContext(typeof(CableProviderContext))]
    [Migration("20220317230426_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CableProvider.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.HasKey("ChannelId");

                    b.HasIndex("PackageId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("CableProvider.Models.ChannelShow", b =>
                {
                    b.Property<int>("ChannelShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.HasKey("ChannelShowId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("ShowId");

                    b.ToTable("ChannelShows");
                });

            modelBuilder.Entity("CableProvider.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BillTotal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CableProvider.Models.CustomerPackage", b =>
                {
                    b.Property<int>("CustomerPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.HasKey("CustomerPackageId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PackageId");

                    b.ToTable("CustomerPackages");
                });

            modelBuilder.Entity("CableProvider.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PackageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PackagePrice")
                        .HasColumnType("int");

                    b.HasKey("PackageId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("CableProvider.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ShowId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("CableProvider.Models.Channel", b =>
                {
                    b.HasOne("CableProvider.Models.Package", null)
                        .WithMany("Channels")
                        .HasForeignKey("PackageId");
                });

            modelBuilder.Entity("CableProvider.Models.ChannelShow", b =>
                {
                    b.HasOne("CableProvider.Models.Channel", "Channel")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CableProvider.Models.Show", "Show")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("CableProvider.Models.CustomerPackage", b =>
                {
                    b.HasOne("CableProvider.Models.Customer", "customer")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CableProvider.Models.Package", "package")
                        .WithMany("JoinEntities")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("package");
                });

            modelBuilder.Entity("CableProvider.Models.Channel", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("CableProvider.Models.Customer", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("CableProvider.Models.Package", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("CableProvider.Models.Show", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
