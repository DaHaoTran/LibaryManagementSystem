using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XAct;
using XSystem.Security.Cryptography;

namespace PRO131_Duan1_FA23.Core.Services
{
    public class DangNhapSvc : IDangNhapSvc
    {
        public string MaNV { get; set; }
        public bool VaiTro { get; set; }

        public bool Login(string email, string password)
        {
            using(var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv = entity.nhanViens.Where(x => x.Email == email && x.MatKhau == password).FirstOrDefault();
                    nv.TinhTrang = true;
                    VaiTro = nv.VaiTro;
                    MaNV = nv.MaNV;
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }
        public bool DoiMatKhau(string email, string password)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv = entity.nhanViens.Where(x => x.Email == email).FirstOrDefault();
                    nv.MatKhau = encryption(password);
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }

        public bool LogOut(string email)
        {
            using(var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv = entity.nhanViens.Where(x => x.Email == email).FirstOrDefault();
                    nv.TinhTrang = false;
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
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

        public bool CheckEmailExist(string email)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nv = entity.nhanViens.Where(x => x.Email == email).FirstOrDefault();
                    if(nv.IsDefaultOrNotInitialized())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                } catch
                {
                    return false;
                }
            }
        }
    }
}
