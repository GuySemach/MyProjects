using System.Configuration;
using EventsApi.Interfaces;
using EventsApi.Logic;
using Microsoft.EntityFrameworkCore;

namespace EventsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigurServices(IServiceCollection services)
        {
            services.AddDbContext<NotificationContext>(opt => opt.UseSqlServer
            (Configuration.GetConnectionString("NotificationsConnection")));
            services.AddControllers();
            services.AddScoped<INotificationsRepo, SqlNotificationRepo>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllers();
            });
        }
    }
}