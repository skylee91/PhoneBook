using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Core;
using PhoneBook.Data;
using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.WinForm
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new MainForm());
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IRepository<Contact>, BaseRepository<Contact>>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
