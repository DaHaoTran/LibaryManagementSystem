using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Models
{
    public class KhachHang
    {
        [Key]
        [MaxLength(6)]
        public string? MaKhachHang { get; set; }
        [MaxLength(50)]
        public string? TenKhachHang { get;set; }
        [MaxLength(10)]
        public string? SoDT {  get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [AllowNull]
        public DateTime NgayMuon { get; set; }
        [AllowNull]
        public DateTime NgayTra {  get; set; }
        [MaxLength(50)]
        public string? MatKhau { get; set; }
        [MaxLength(40)]
        public string? TrangThai { get; set; }

        [ForeignKey("nhanViens")]
        [MaxLength(6)]
        public string? MaNV { get; set; }
        public NhanVien? nhanViens;

        [ForeignKey("saches")]
        [MaxLength(6)]
        [AllowNull]
        public string? MaSach;
        public List<Sach>? saches;
    }
}
