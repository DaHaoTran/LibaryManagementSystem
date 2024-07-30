using Autofac;
using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormLogin : Form
    {
        private IDangNhapSvc svc;
        private Autofac.IContainer container = Configure();
        public static FormLogin? instance;
        private bool VaiTro;
        public static string? MaNV;
        public FormLogin(IDangNhapSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            instance = this;
            this.KeyPreview = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DangNhapSvc>().As<IDangNhapSvc>();
            builder.RegisterType<FormMain>();
            builder.RegisterType<FormQuenMK>();
            return builder.Build();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text.Trim();
            string password = txtPass.Text.Trim();
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                if (svc.Login(email, svc.encryption(password)))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    MaNV = svc.MaNV;
                    FormMain.instance.maNv = MaNV;
                    FormMain.instance.eMail = email;
                    VaiTro = svc.VaiTro;
                    if (VaiTro == true)
                    {
                        FormMain.instance.StartAnAdmin();
                        this.Close();

                    }
                    else
                    {
                        this.Close();
                        FormMain.instance.StartAnStaff();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string pass = "acwd gzuc knqp xmbu";
        private string email = "nhao4771@gmail.com";
        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text.Trim()))
            {
                string to = txtLogin.Text.Trim();
                if (svc.CheckEmailExist(to))
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(email);
                    mail.To.Add(to);
                    mail.Subject = "Xác nhận email";
                    Random rand = new Random();
                    int randotp = rand.Next(100000, 999999);
                    mail.Body = "Mã xác nhận của bạn là : " + randotp;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(email, pass);
                    try
                    {
                        smtp.Send(mail);
                        MessageBox.Show("Gửi mã xác nhận thành công");
                        FormQuenMK.email = to;
                        FormQuenMK.getotp = randotp.ToString();
                        OpenChildForm(new FormQuenMK(container.Resolve<IDangNhapSvc>()));
                    }
                    catch
                    {
                        MessageBox.Show("Gửi mã xác nhận thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy email");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập email để tiến hành đổi mật khẩu");
            }

        }

        private Form currenChild;
        private void OpenChildForm(Form childform)
        {
            if (currenChild != null)
            {
                currenChild.Close();
            }
            currenChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childform);
            panelBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
