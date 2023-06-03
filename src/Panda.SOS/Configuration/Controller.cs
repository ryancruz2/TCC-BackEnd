namespace Panda.SOS.Configuration;
public static class Controller
{
    public static IServiceCollection ConfigureController(this IServiceCollection services, string connectionString)
    {
        services.AddControllers();
        return services;
    }
}
