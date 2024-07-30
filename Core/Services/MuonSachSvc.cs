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
    public class MuonSachSvc : IMuonSachSvc
    {
        public string GetTenNhaXB(string maxb)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.nhaXBs.Where(x => x.MaXB == maxb).Select(x => x.TenNhaXB).FirstOrDefault();
            }
        }

        public List<Sach> GetSach()
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.sachs.Take(5).ToList();
            }
        }

        public bool TimThongTinKH(string tt)
        {
            using (var entity = new QLThuVienDBContext()) 
            {
                try
                {
                    var kh = entity.khachHangs.Where(x => x.Email == tt || x.MaKhachHang == tt).FirstOrDefault();
                    if(kh.IsDefaultOrNotInitialized())
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                } catch { return false; }
            }
        }

        public void MuonSach(string makh, string masach, string manv , DateTime hantra)
        {
            using (var entity = new QLThuVienDBContext())
            {
                KhachHangSach l = new KhachHangSach();
                l.MaSach = masach;
                l.MaKhachHang = makh;
                entity.KhachHangSach.Add(l);
                var s = entity.sachs.Where(x => x.MaSach == masach).FirstOrDefault();
                if(s.TrangThai != "Đang được mượn")
                {
                    s.TrangThai = "Đang được mượn";
                }
                var kh = entity.khachHangs.Where(x => x.MaKhachHang == makh).FirstOrDefault();
                kh.NgayMuon = DateTime.UtcNow;
                kh.NgayTra = hantra.ToUniversalTime();
 
                if(kh.TrangThai != "Đang mượn")
                {
                    kh.TrangThai = "Đang mượn";
                }
                entity.SaveChanges();
            }
        }

        public List<Sach> FindSach(string tt)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.sachs.Where(x => x.MaSach.Contains(tt) || x.TenSach.Contains(tt) || x.TacGia.Contains(tt) || x.LoaiSach.Contains(tt)).ToList();
            }
        }

        public List<KhachHang> GetKhachHang()
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Take(5).ToList();
            }
        }

        public List<KhachHang> FindKhachHang(string tt)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Where(x => x.MaKhachHang.Contains(tt) || x.TenKhachHang.Contains(tt) || x.SoDT.Contains(tt) || x.Email.Contains(tt)).ToList();
            }
        }

        public int CountSachMuon(string makh)
        {
            using (var entity = new QLThuVienDBContext())
            {
                var kh = entity.KhachHangSach.Where(x => x.MaKhachHang == makh).ToList();
                var sachlist = kh.Join(entity.sachs, x => x.MaSach, x => x.MaSach, (kh, s) => new Sach
                {
                    MaSach = s.MaSach,
                }).ToList();
                return sachlist.Count;
            }
        }
    }
}
