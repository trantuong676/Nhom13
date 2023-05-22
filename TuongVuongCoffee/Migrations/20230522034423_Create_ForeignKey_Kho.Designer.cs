﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TuongVuongCoffee.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230522034423_Create_ForeignKey_Kho")]
    partial class Create_ForeignKey_Kho
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("TuongVuongCoffee.Models.HoaDon", b =>
                {
                    b.Property<string>("HoaDonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoaDonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoLuong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HoaDonID");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("TuongVuongCoffee.Models.KhachHang", b =>
                {
                    b.Property<string>("KhachHangCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KhachHangName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("KhachHangCode");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("TuongVuongCoffee.Models.Kho", b =>
                {
                    b.Property<string>("KhoID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExportKho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InventoryKho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KhoStoreExists")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberKho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SanPhamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("KhoID");

                    b.HasIndex("SanPhamName");

                    b.ToTable("Kho");
                });

            modelBuilder.Entity("TuongVuongCoffee.Models.NhanVien", b =>
                {
                    b.Property<string>("NhanVienCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NhanVienName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NhanVienCode");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("TuongVuongCoffee.Models.SanPham", b =>
                {
                    b.Property<string>("SanPhamID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SanPhamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SanPhamID");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("TuongVuongCoffee.Models.Kho", b =>
                {
                    b.HasOne("TuongVuongCoffee.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });
#pragma warning restore 612, 618
        }
    }
}