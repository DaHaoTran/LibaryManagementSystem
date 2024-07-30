using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface IQLSachSvc 
    {
        string TaoMaSachMoi();
        bool ThemSach(Sach s);
        bool SuaSach(Sach s);
        bool XoaSach(string masach);
        List<Sach> GetSach(int numpage, int numrecord);
        List<Sach> FindSach(string tensach);
        string getTenXB(string maxb);
        List<string> GetListTenNXB();
    }
}
