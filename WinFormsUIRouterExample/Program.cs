using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUIRouterExample.Components.Pages;

namespace WinFormsUIRouterExample
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot().Resolve<MainForm>());
        }

        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();

            // Register UIRouter as singleton.
            builder.RegisterType<UIRouter>().SingleInstance();
            builder.RegisterType<MainForm>().SingleInstance();
            builder.RegisterType<WarehousesControl>();
            builder.RegisterType<NewWarehouseControl>();
            builder.RegisterType<EditWarehouseControl>();
            builder.RegisterType<PartsControl>();
            builder.RegisterType<NewPartControl>();
            builder.RegisterType<EditPartControl>();

            return builder.Build();
        }
    }
}
