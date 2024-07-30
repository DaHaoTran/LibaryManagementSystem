using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface IMuonSachSvc
    {
        List<Sach> GetSach();
        List<Sach> FindSach(string tt);
        string GetTenNhaXB(string maxb);
        bool TimThongTinKH(string tt);
        void MuonSach(string makh, string masach, string manv, DateTime hantra);
        List<KhachHang> GetKhachHang();
        List<KhachHang> FindKhachHang(string tt);
        int CountSachMuon(string makh);
    }
}
