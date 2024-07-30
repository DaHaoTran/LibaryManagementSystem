using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface ITraSachSvc
    {
        List<Sach> GetListSM(string makh);
        DateTime GetNgayTra(string makh);
        bool TraSach(string makh);
        List<KhachHang> GetKhachHang();
        List<KhachHang> FindKhachHang(string tt);
    }
}
