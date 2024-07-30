using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Models
{
    public class NhanVien
    {
        [Key]
        [MaxLength(6)]
        public string? MaNV {  get; set; }
        [MaxLength(50)]
        public string? TenNV { get; set; }
        [MaxLength (10)]
        public string? SoDT { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(100)]
        public string? DiaChi { get; set; }
        public bool VaiTro { get; set; }
        [MaxLength(50)]
        public string? MatKhau { get; set; }
        public bool TinhTrang { get; set; }
        [AllowNull]
        public byte[]? Hinh { get; set; }

        /*[ForeignKey("nhaXBs")]
        public List<NhaXB>? nhaXBs { get; set; }

        [ForeignKey("saches")]
        public List<Sach>? saches { get; set; }

        [ForeignKey("khachHangs")]
        public List<KhachHang>? khachHangs { get; set; } */
    }
}
