using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsApp1;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;
using WinFormsApp1.Services;

namespace YourNamespace {
    static class Program {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main() {
            // �]�m�̿�`�J�e��
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // �q�A�ȴ��Ѫ̤����o�D�����
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services) {
            services.AddTransient<Form1>();
            services.AddDbContext<AdventureWorksDW2022Context>(options =>
                options.UseSqlServer("Data Source=localhost;Initial Catalog=AdventureWorksDW2022;User ID=sa;Password=pass.123;Trust Server Certificate=True"));
            services.AddScoped<ICustomerService, CustomerService>();

        }
    }
}