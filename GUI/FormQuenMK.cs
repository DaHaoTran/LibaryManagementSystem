using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormQuenMK : Form
    {
        private IDangNhapSvc svc;
        public static string? getotp;
        public static string? email;
        public FormQuenMK(IDangNhapSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            this.KeyPreview = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin.instance.Show();
        }

        private void FormQuenMK_Load(object sender, EventArgs e)
        {

        }

        private bool CheckValidatePass(string pass)
        {
            bool re = false;
            Regex rg = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng");
                re = false;
            }
            else
            {
                re = rg.IsMatch(pass);
            }
            return re;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string otp = txtOTP.Text.Trim();
            string newpass = txtNewPass.Text.Trim();
            string confirmpass = txtConfirmPass.Text.Trim();
            if (!string.IsNullOrEmpty(otp) && !string.IsNullOrEmpty(newpass) && !string.IsNullOrEmpty(confirmpass))
            {
                if (otp == getotp)
                {
                    if (CheckValidatePass(newpass))
                    {
                        if (confirmpass == newpass)
                        {
                            if (svc.DoiMatKhau(email, newpass))
                            {
                                MessageBox.Show("Đổi mật khẩu thành công, quay về trang đăng nhập");
                                this.Close();
                                FormLogin.instance.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu xác nhận không trùng khớp");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải chứa 8 ký tự, ít nhất một chữ cái viết hoa, một chữ và một số");
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP chưa đúng");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
        }

        private void FormQuenMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDoiMK_Click(sender, e);
            }
        }
    }
}
