using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface IQLKhachHangSvc
    {
        List<KhachHang> GetKhachHang(int numpage, int numrecord);
        string TaoNewMaKhachHang();
        bool ThemKhachHang(KhachHang kh);
        bool SuaKhachHang(KhachHang kh);
        bool XoaKhachHang(string makhachhang);
        bool CheckNotExistEmail(string email);
        string encryption(string password);
        List<KhachHang> FindKhachHang(string tenkh);
    }
}
