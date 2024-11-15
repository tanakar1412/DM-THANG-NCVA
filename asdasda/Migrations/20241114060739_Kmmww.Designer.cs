﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asdasda.Models;

#nullable disable

namespace asdasda.Migrations
{
    [DbContext(typeof(PhucDbContext))]
    [Migration("20241114060739_Kmmww")]
    partial class Kmmww
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("asdasda.Models.KHCT", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KhoaHocID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("SinhVienID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("KhoaHocID");

                    b.HasIndex("SinhVienID");

                    b.ToTable("KHCTs");
                });

            modelBuilder.Entity("asdasda.Models.KhoaHoc", b =>
                {
                    b.Property<string>("MaPB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPB");

                    b.ToTable("khoaHoc");
                });

            modelBuilder.Entity("asdasda.Models.SinhVien", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("sinhViens");
                });

            modelBuilder.Entity("asdasda.Models.KHCT", b =>
                {
                    b.HasOne("asdasda.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("KHCTs")
                        .HasForeignKey("KhoaHocID");

                    b.HasOne("asdasda.Models.SinhVien", "SinhVien")
                        .WithMany("KHCTs")
                        .HasForeignKey("SinhVienID");

                    b.Navigation("KhoaHoc");

                    b.Navigation("SinhVien");
                });

            modelBuilder.Entity("asdasda.Models.KhoaHoc", b =>
                {
                    b.Navigation("KHCTs");
                });

            modelBuilder.Entity("asdasda.Models.SinhVien", b =>
                {
                    b.Navigation("KHCTs");
                });
#pragma warning restore 612, 618
        }
    }
}
