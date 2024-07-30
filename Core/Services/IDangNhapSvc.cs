using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_Duan1_FA23.Core.Services
{
    public interface IDangNhapSvc
    {
        string MaNV { get; set; }
        bool VaiTro {  get; set; }
        bool Login(string email, string password);
        bool DoiMatKhau(string email, string password);
        bool LogOut(string email);
        string encryption(string password);
        bool CheckEmailExist(string email);
    }
}
