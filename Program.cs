using Autofac;
using PRO131_Duan1_FA23.Core.Services;
using PRO131_Duan1_FA23.GUI;
using System.ComponentModel;

namespace PRO131_Duan1_FA23
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Autofac.IContainer container = Configure();
            //Application.Run(new LoadingForm());
            //Application.Run(new FormMain(container.Resolve<IDangNhapSvc>()));
            //Application.Run(new FormQLNV(container.Resolve<IQLNhanVienSvc>()));
            //Application.Run(new FormQLKH(container.Resolve<IQLKhachHangSvc>()));
            //Application.Run(new FormQLS(container.Resolve<IQLSachSvc>()));
            //Application.Run(new FormMuonSach(container.Resolve<IMuonSachSvc>()));
            //Application.Run(new FormTraSach(container.Resolve<ITraSachSvc>()));
            //Application.Run(new FormThongKe());
            //Application.Run(new FormLogin());
            //Application.Run(new FormDoiMK());
            //Application.Run(new FormCNNXB(container.Resolve<INhaXBSvc>()));
            Application.Run(new LoadingForm());
        }
        static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DangNhapSvc>().As<IDangNhapSvc>();
            builder.RegisterType<NhaXBSvc>().As<INhaXBSvc>();
            builder.RegisterType<QLNhanVienSvc>().As<IQLNhanVienSvc>();
            builder.RegisterType<QLSachSvc>().As<IQLSachSvc>();
            builder.RegisterType<QLKhachHangSvc>().As<IQLKhachHangSvc>();
            builder.RegisterType<MuonSachSvc>().As<IMuonSachSvc>();
            builder.RegisterType<TraSachSvc>().As<ITraSachSvc>();
            builder.RegisterType<FormMain>();
            builder.RegisterType<FormCNNXB>();
            builder.RegisterType<FormQLNV>();
            builder.RegisterType<FormQLS>();
            builder.RegisterType<FormQLKH>();
            builder.RegisterType<FormMuonSach>();
            builder.RegisterType<FormTraSach>();
            return builder.Build();
        }
    }
}