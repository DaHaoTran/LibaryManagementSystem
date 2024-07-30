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
    public class NhaXB
    {
        [Key]
        [MaxLength(6)]
        public string? MaXB { get; set; }
        [MaxLength(50)]
        public string? TenNhaXB { get; set; }
        [MaxLength(50)]
        public string? DiaChi {  get; set; }
        [MaxLength(10)]
        public string? SoDT { get; set; }
        [MaxLength(500)]
        [AllowNull]
        public string? GhiChu { get; set; }
       
        [ForeignKey("nhanViens")]
        [MaxLength(6)]
        public string? MaNV { get; set; }
        public NhanVien? nhanViens;

        /*[ForeignKey("saches")]
        public List<Sach>? saches { get; set; } */
    }
}
