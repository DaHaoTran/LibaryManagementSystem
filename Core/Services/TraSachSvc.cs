using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;

namespace PRO131_Duan1_FA23.Core.Services
{
    public class TraSachSvc : ITraSachSvc
    {
        public List<KhachHang> FindKhachHang(string tt)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Where(x => x.MaKhachHang.Contains(tt) || x.TenKhachHang.Contains(tt) || x.SoDT.Contains(tt) || x.Email.Contains(tt)).ToList();
            }
        }

        public List<KhachHang> GetKhachHang()
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Take(5).ToList();
            }
        }

        public List<Sach> GetListSM(string makh)
        {
            using (var entity = new QLThuVienDBContext())
            {
                var kh = entity.KhachHangSach.Where(x => x.MaKhachHang == makh).ToList();
                var sachlist = kh.Join(entity.sachs, x => x.MaSach, x => x.MaSach, (kh, s) => new Sach
                {
                    MaSach = s.MaSach,
                    TenSach = s.TenSach,
                    TacGia = s.TacGia,
                    LoaiSach = s.LoaiSach,
                    TinhTrang = s.TinhTrang,
                    TrangThai = s.TrangThai,
                    SoLuong = s.SoLuong,
                    MaNV = s.MaNV,
                    MaXB = s.MaXB
                }).ToList();
                return sachlist;
            }
        }

        public DateTime GetNgayTra(string makh)
        {
            using(var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Where(x => x.MaKhachHang == makh).Select(x => x.NgayTra).FirstOrDefault();
            }
        }

        public bool TraSach(string makh)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var kh = entity.KhachHangSach.Where(x => x.MaKhachHang == makh).ToList();
                    entity.KhachHangSach.RemoveRange(kh);
                    
                    var khtt = entity.khachHangs.Where(x => x.MaKhachHang == makh).FirstOrDefault();
                    khtt.TrangThai = "Đã trả"; 

                    if(entity.KhachHangSach.Count() == 0)
                    {
                        entity.sachs.ForEach(x => x.TrangThai = "none");
                    } else
                    {
                        var s = entity.sachs.Join(entity.KhachHangSach, x => x.MaSach, x => x.MaSach, (sach, muon) => new
                        {
                            sach,
                            muon
                        });
                        var kotontai = entity.sachs.Where(x => !s.Any(v => v.sach.MaSach == x.MaSach));
                        entity.sachs.ForEach(x => x.TrangThai = "none");
                    }
            
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
               
            }
        }
    }
}
