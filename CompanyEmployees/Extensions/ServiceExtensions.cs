using Contracts; // Didnt tell us to add, Contract and logger should be globaly added.
using LoggerService;

namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        // .WithOrigins("https://example.com")
        // .WithMethods("POST", "GET")
        // .WithHeaders("accept", "contenttype")
        public static void ConfigureCors(this IServiceCollection services) =>
         services.AddCors(options =>
         {
             options.AddPolicy("CorsPolicy", builder =>
             builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
         });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
                {
                    //options.AutomaticAuthentication = true;
                    //options.AuthenticationDisplayName = "Krille";
                    //options.ForwardClientCertificate = true;
                });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

    }

}
