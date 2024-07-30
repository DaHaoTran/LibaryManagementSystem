using Autofac;
using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormMain : Form
    {
        private IDangNhapSvc svc;
        public string maNv;
        public string eMail;
        private Autofac.IContainer container = Configure();
        static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DangNhapSvc>().As<IDangNhapSvc>();
            builder.RegisterType<NhaXBSvc>().As<INhaXBSvc>();
            builder.RegisterType<QLSachSvc>().As<IQLSachSvc>();
            builder.RegisterType<QLNhanVienSvc>().As<IQLNhanVienSvc>();
            builder.RegisterType<QLKhachHangSvc>().As<IQLKhachHangSvc>();
            builder.RegisterType<MuonSachSvc>().As<IMuonSachSvc>();
            builder.RegisterType<TraSachSvc>().As<ITraSachSvc>();
            builder.RegisterType<FormLogin>();
            builder.RegisterType<FormDoiMK>();
            builder.RegisterType<FormCNNXB>();
            builder.RegisterType<FormQLS>();
            builder.RegisterType<FormQLNV>();
            builder.RegisterType<FormQLKH>();
            builder.RegisterType<FormMuonSach>();
            builder.RegisterType<FormTraSach>();
            return builder.Build();
        }
        private void Start()
        {
            btnLogin.Enabled = true;
            btnDangXuat.Enabled = false;
            btnDoiMK.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnQLKhachHang.Enabled = false;
            btnQLMuonTraSach.Enabled = false;
            btnNhaXB.Enabled = false;
            btnQLThongKe.Enabled = false;
            btnQLSach.Enabled = false;
        }
        public void StartAnAdmin()
        {
            btnLogin.Enabled = false;
            btnDoiMK.Enabled = true;
            btnDangXuat.Enabled = true;
            btnPhanQuyen.Enabled = true;
            btnQLThongKe.Enabled = true;
            btnNhaXB.Enabled = true;
        }
        public void StartAnStaff()
        {
            btnLogin.Enabled = false;
            btnDoiMK.Enabled = true;
            btnDangXuat.Enabled = true;
            btnQLKhachHang.Enabled = true;
            btnQLMuonTraSach.Enabled = true;
            btnQLSach.Enabled = true;

        }
        //tuong tác form    
        //public FormMain()
        //{
        //    InitializeComponent();
        //}
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
        public static FormMain? instance;
        public FormMain(IDangNhapSvc _svc)
        {
            InitializeComponent();
            Start();
            svc = _svc;
            instance = this;
            LoadingForm.instance.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(eMail))
            {
                if (svc.LogOut(eMail))
                {

                    Close();
                }
                else
                {
                    MessageBox.Show("Error System");
                }
            }
            else
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLogin(container.Resolve<IDangNhapSvc>()));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (svc.LogOut(eMail))
            {
                this.Refresh();
                Start();
                eMail = string.Empty;
            }
            else
            {
                MessageBox.Show("Error System");
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoiMK(container.Resolve<IDangNhapSvc>()));
        }

        private void btnNhaXB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCNNXB(container.Resolve<INhaXBSvc>()));
        }

        private void pcBoxQLS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLS(container.Resolve<IQLSachSvc>()));
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLNV(container.Resolve<IQLNhanVienSvc>()));
        }

        private void pcBoxKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKH(container.Resolve<IQLKhachHangSvc>()));
        }

        private void pcBoxTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
        }

        private void lBMuon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormMuonSach(container.Resolve<IMuonSachSvc>()));
        }

        private void lBTra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormTraSach(container.Resolve<ITraSachSvc>()));
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Details.pdf");
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    FileName = path, //put the correct path here
                    UseShellExecute = true
                };
                p.Start();
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
