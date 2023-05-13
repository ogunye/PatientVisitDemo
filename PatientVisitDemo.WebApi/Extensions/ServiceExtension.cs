using LoggerService;
using PatientVisitDemo.Application.Common;

namespace PatientVisitDemo.WebApi.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(option =>
            option.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()));
        
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(option => { });
        }

        public static void ConfigureLoggerService(this IServiceCollection services) => services.AddSingleton<ILoggerManager, LoggerManager>();
        

    }     
}
    