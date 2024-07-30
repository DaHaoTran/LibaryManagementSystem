using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Models
{
    public class Sach
    {
        [Key]
        [MaxLength(6)]
        public string? MaSach {  get; set; }
        [MaxLength(100)]
        public string? TenSach { get; set; }
        [MaxLength(50)]
        public string? TacGia { get; set; }
        [MaxLength(50)]
        public string? LoaiSach { get; set; }
        public bool TinhTrang { get; set; }
        [MaxLength(50)]
        public string? TrangThai { get; set; }
        public int SoLuong { get; set; }
       
        [ForeignKey("nhanViens")]
        [MaxLength(6)]
        public string? MaNV { get; set; }
        public NhanVien? nhanViens;
      
        [ForeignKey("nhaXBs")]
        [MaxLength(6)]
        public string? MaXB { get; set; }
        public NhaXB? nhaXBs;

        [ForeignKey("khachHangs")]
        public List<KhachHang>? khachHangs;
    }
}
