using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormDoiMK : Form
    {
        private IDangNhapSvc svc;
        public FormDoiMK(IDangNhapSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            txtTK.Text = FormMain.instance?.eMail;
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
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
            string oldpass = txtOldPass.Text.Trim();
            string newpass = txtNewPass.Text.Trim();
            string confirmpass = txtNewPassA.Text.Trim();
            if (!string.IsNullOrEmpty(oldpass))
            {
                if (!string.IsNullOrEmpty(newpass) && !string.IsNullOrEmpty(confirmpass))
                {
                    if (confirmpass == newpass)
                    {
                        if (CheckValidatePass(newpass))
                        {
                            if (svc.DoiMatKhau(txtTK.Text.Trim(), newpass))
                            {
                                MessageBox.Show("Đổi mật khẩu thành công");
                                Close();
                                FormMain.instance.Show();
                            }
                            else
                            {
                                MessageBox.Show("Đổi mật khẩu thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu phải chứa 8 ký tự, ít nhất một chữ cái viết hoa, một chữ và một số");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin yêu cầu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDoiMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDoiMK_Click(sender, e);
            }
        }
    }
}
