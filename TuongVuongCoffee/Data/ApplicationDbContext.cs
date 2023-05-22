using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TuongVuongCoffee.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TuongVuongCoffee.Models.NhanVien> NhanVien { get; set; } = default!;

        public DbSet<TuongVuongCoffee.Models.SanPham> SanPham { get; set; } = default!;

        public DbSet<TuongVuongCoffee.Models.KhachHang> KhachHang { get; set; } = default!;

        public DbSet<TuongVuongCoffee.Models.HoaDon> HoaDon { get; set; } = default!;

        public DbSet<TuongVuongCoffee.Models.Kho> Kho { get; set; } = default!;
    }
