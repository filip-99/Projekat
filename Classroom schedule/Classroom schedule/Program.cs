using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_schedule
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServisec(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var Home = serviceProvider.GetRequiredService<Home>();
                Application.Run(Home);
            }
        }

        private static void ConfigureServisec(ServiceCollection services)
        {
            services.AddScoped<ISchedulingRepository, SchedulingRepository>();
            services.AddScoped<IPeriodRepository, PeriodRepository>();
            services.AddScoped<IClassroomRepository,    ClassroomRepository>();
            services.AddScoped<ISchedulingBusiness, SchedulingBusiness>();
            services.AddScoped<IPeriodBusiness, PeriodBusiness>();
            services.AddScoped<IClassroomBusiness, ClassroomBusiness>();
            services.AddScoped<Home>();
            services.AddScoped<Login2>();
            services.AddScoped<Schedule>();



        }
    }
}
