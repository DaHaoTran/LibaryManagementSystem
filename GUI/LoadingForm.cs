using Autofac;
using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class LoadingForm : Form
    {
        private Autofac.IContainer container = Configure();
        public static LoadingForm instance;
        public LoadingForm()
        {
            InitializeComponent();
            timer2.Start();
            instance = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 800)
            {
                timer2.Stop();
                FormMain formMain = new FormMain(container.Resolve<IDangNhapSvc>());
                formMain.ShowDialog();
                this.Close();
            }


        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DangNhapSvc>().As<IDangNhapSvc>();
            builder.RegisterType<FormMain>();
            return builder.Build();
        }

    }
}
