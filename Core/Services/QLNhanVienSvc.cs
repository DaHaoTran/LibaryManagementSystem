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
    public class QLNhanVienSvc : IQLNhanVienSvc
    {
        public bool CheckNotExistEmail(string email)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv = entity.nhanViens.Where(x => x.Email != email).FirstOrDefault();
                    if(nv.IsDefaultOrNotInitialized())
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                } catch { return false; }
            }
        }

        public List<NhanVien> GetNhanVien(int numpage, int numrecord)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.nhanViens.Skip((numpage-1) * numrecord).Take(numrecord).ToList();
            }
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv1 = entity.nhanViens.Where(x => x.MaNV == nv.MaNV).FirstOrDefault();
                    nv1.TenNV = nv.TenNV;
                    nv1.SoDT = nv.SoDT;
                    nv1.Email = nv.Email;
                    nv1.DiaChi = nv.DiaChi;
                    nv1.VaiTro = nv.VaiTro;
                    nv1.TinhTrang = nv.TinhTrang;
                    nv1.Hinh = nv.Hinh;
                    entity.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }

        public string TaoNewMaNV()
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    List<string> stringlist = entity.nhanViens.Select(x => x.MaNV).ToList();
                    List<int> intlist = stringlist.Select(x => int.Parse(x.Substring(4))).ToList();
                    int max = intlist.Max() + 1;
                    if (max < 10)
                    {
                        return "NV000" + max;
                    } else if (max < 100)
                    {
                        return "NV00" + max;
                    } else if (max < 1000)
                    {
                        return "NV0" + max;
                    } else
                    {
                        return "NV" + max;
                    }
                }
                catch { return "NV0001"; }
            }
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    entity.nhanViens.Add(nv);
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }

        public bool XoaNhanVien(string manv)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv = entity.nhanViens.Where(x => x.MaNV == manv).FirstOrDefault();
                    entity.nhanViens.Remove(nv);
                    entity.SaveChanges();
                    return true;
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

        public List<NhanVien> FindNhanVien(string tennv)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.nhanViens.Where(x => x.TenNV.Contains(tennv)).ToList();
            }
        }
    }
}
