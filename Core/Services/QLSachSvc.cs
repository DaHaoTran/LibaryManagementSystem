using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public class QLSachSvc : IQLSachSvc
    {
        public List<Sach> FindSach(string tensach)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.sachs.Where(x => x.TenSach.Contains(tensach)).ToList();
            }
        }

        public List<Sach> GetSach(int numpage, int numrecord)
        {
            using(var entity = new QLThuVienDBContext())
            {
                return entity.sachs.Skip((numpage-1) * numrecord).Take(numrecord).ToList();
            }
        }

        public List<string> GetListTenNXB()
        {
            var list = new List<string>();
            using (var entity = new QLThuVienDBContext())
            {
                if(entity.nhaXBs.Count() > 0)
                {
                   list = entity.nhaXBs.Select(x => x.TenNhaXB).ToList();
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu của nhà xuất bản nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return list;
            }
        }

        public string getTenXB(string maxb)
        {
            using (var entity = new QLThuVienDBContext()) 
            {
                return entity.nhaXBs.Where(x => x.MaXB == maxb).Select(x => x.TenNhaXB).FirstOrDefault();
            }
        }

        public bool SuaSach(Sach s)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var sach = entity.sachs.Where(x => x.MaSach == s.MaSach).FirstOrDefault();
                    sach.TenSach = s.TenSach;
                    sach.TacGia = s.TacGia;
                    sach.LoaiSach = s.LoaiSach;
                    sach.TinhTrang = s.TinhTrang;
                    sach.TrangThai = s.TrangThai;
                    sach.SoLuong = s.SoLuong;
                    sach.MaNV = s.MaNV;
                    var maxb = entity.nhaXBs.Where(x => x.TenNhaXB.Contains(s.MaXB)).Select(x => x.MaXB).FirstOrDefault();
                    sach.MaXB = maxb;
                    entity.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }

        public string TaoMaSachMoi()
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    List<string> stringlist = entity.sachs.Select(x => x.MaSach).ToList();
                    List<int> intlist = stringlist.Select(x => int.Parse(x.Substring(5))).ToList();
                    int max = intlist.Max() + 1;
                    if (max < 10)
                    {
                        return "B0000" + max;
                    } else if (max < 100)
                    {
                        return "B000" + max;
                    } else if (max < 1000)
                    {
                        return "B00" + max;
                    } else if (max < 10000)
                    {
                        return "B0" + max;
                    } else
                    {
                        return "B" + max;
                    }
                }
                catch { return "B00001"; }
            }
        }

        public bool ThemSach(Sach s)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var maxb = entity.nhaXBs.Where(x => x.TenNhaXB.Contains(s.MaXB)).Select(x => x.MaXB).FirstOrDefault();
                    s.MaXB = maxb;
                    entity.sachs.Add(s);
                    entity.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }

        public bool XoaSach(string masach)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var sach = entity.sachs.Where(x => x.MaSach == masach).FirstOrDefault();
                    entity.sachs.Remove(sach);
                    entity.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
    }
}
