using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface INhaXBSvc
    {
        bool ThemNhaXB(NhaXB xb);
        bool CapNhapNhaXB(NhaXB xb);
        bool XoaNhaXB(string maxb);
        string NewMaXB();
        List<NhaXB> GetNhaXB(int numpage, int numrecord);
        List<NhaXB> FindNhaXB(string tennhaxb);
    }
}
