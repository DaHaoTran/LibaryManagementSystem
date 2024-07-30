using Microsoft.EntityFrameworkCore;
using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Context
{
    public class QLThuVienDBContext : DbContext
    {
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<Sach> sachs { get; set; }
        public DbSet<NhaXB> nhaXBs { get; set; }
        public DbSet<KhachHangSach> KhachHangSach { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("...");
        }
    }
}
