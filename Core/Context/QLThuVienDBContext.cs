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
            optionsBuilder.UseNpgsql("Host=pub-QuanLyThuVien-kpb65er2-581339f.dbaas.bfcplatform.vn;Username=root;Password=wKZ2eCy69nDm4BBtivM9i7HyjTZTiVA6Cyso;database=QuanLyThuVienDB;Port=5432");
        }
    }
}
