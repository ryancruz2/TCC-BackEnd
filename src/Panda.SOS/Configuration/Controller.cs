namespace Panda.SOS.Configuration;
public static class Controller
{
    public static IServiceCollection ConfigureController(this IServiceCollection services)
    {
       services.AddControllers();
       return services;
    }
}