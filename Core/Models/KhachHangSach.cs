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
    public class KhachHangSach
    {
        [Key]
        public int STT { get; set; }

        [ForeignKey("KhachHang")]
        [MaxLength(6)]
        public string? MaKhachHang { get; set; } //MaKH
        public KhachHang? KhachHang;

        [ForeignKey("Sach")]
        [MaxLength(6)]
        public string? MaSach { get; set; } //MaSach
        public Sach? Sach;

    }
}
