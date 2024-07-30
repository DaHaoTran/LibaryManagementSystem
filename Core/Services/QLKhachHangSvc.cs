using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;
using XSystem.Security.Cryptography;

namespace PRO131_Duan1_FA23.Core.Services
{
    public class QLKhachHangSvc : IQLKhachHangSvc
    {
        public bool CheckNotExistEmail(string email)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var kh = entity.khachHangs.Where(x => x.Email != email).FirstOrDefault();  
                    if (kh.IsDefaultOrNotInitialized())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch { return false; }
            }
        }

        public string encryption(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = md5.ComputeHash(encoding.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        public List<KhachHang> FindKhachHang(string tenkh)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Where(x => x.TenKhachHang.Contains(tenkh)).ToList();
            }
        }

        public List<KhachHang> GetKhachHang(int numpage, int numrecord)
        {
            using(var entity = new QLThuVienDBContext())
            {
                return entity.khachHangs.Skip((numpage-1) * numrecord).Take(numrecord).ToList();
            }
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            using(var entity = new QLThuVienDBContext())
            {
                try
                {
                    var kh1 = entity.khachHangs.Where(x => x.MaKhachHang == kh.MaKhachHang).FirstOrDefault();
                    kh1.TenKhachHang = kh.TenKhachHang;
                    kh1.SoDT = kh.SoDT;
                    kh1.Email = kh.Email;
                    kh1.TrangThai = kh.TrangThai;
                    kh1.MaNV = kh.MaNV;
                    entity.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }

        public string TaoNewMaKhachHang()
        {
            using (var entity = new QLThuVienDBContext()) 
            { 
                try
                {
                    List<string> stringlist = entity.khachHangs.Select(x => x.MaKhachHang).ToList();
                    List<int> intlist = stringlist.Select(x => int.Parse(x.Substring(4))).ToList();
                    int max = intlist.Max() + 1;
                    if(max < 10)
                    {
                        return "KH000" + max;
                    } else if (max < 100)
                    {
                        return "KH00" + max;
                    } else if (max < 1000)
                    {
                        return "KH0" + max;
                    } else
                    {
                        return "KH" + max;
                    }
                } catch { return "KH0001"; }
            }
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            using (var entity = new QLThuVienDBContext()) 
            {
                try
                {
                    entity.khachHangs.Add(kh);
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }

        public bool XoaKhachHang(string makhachhang)
        {
            using(var entity = new QLThuVienDBContext())
            {
                try
                {
                    var kh = entity.khachHangs.Where(x => x.MaKhachHang == makhachhang).FirstOrDefault();
                    entity.khachHangs.Remove(kh);
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }
    }
}
