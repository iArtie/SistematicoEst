using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistematico.Domain.PepitoSchoolEntities;
using Sistematico.Domain.Interfaces;
using Sistematico.Infraestructure.Repository;
using Sistematico.Applications.Interfaces;
using Sistematico.Applications.Services;

namespace Sistematico
{
    static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("AppSetings.json")
                .AddEnvironmentVariables().Build();
            //.AddJsonFile("appsettings.json")
            //.AddEnvironmentVariables().Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            services.AddDbContext<PepitoSchoolContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<ISistematicoContext, PepitoSchoolContext>();
            services.AddScoped<IEstudianteRepository, EFEstudianteRepository>();
            services.AddScoped<IEstudianteService, EstudianteService>();
            services.AddScoped<Form1>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<Form1>();
                Application.Run(main);
            }

        }
    }
}
