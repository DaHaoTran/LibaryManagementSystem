using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface IQLNhanVienSvc
    {
        string TaoNewMaNV();
        bool ThemNhanVien(NhanVien nv);
        bool SuaNhanVien(NhanVien nv);
        bool XoaNhanVien(string manv);
        List<NhanVien> GetNhanVien(int numpage, int numrecord);
        bool CheckNotExistEmail(string email);
        string encryption(string password);
        List<NhanVien> FindNhanVien(string tennv);
    }
}
