namespace Panda.SOS.Configuration;

public static class DatabaseConfig
{
    public static IServiceCollection ConfigureDatabase(this IServiceCollection services, string connectionString)
    {

#if (DEBUG)
        services.AddDbContext<EFContext>(options =>
                options
                .UseNpgsql(connectionString, opt => opt.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds))
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                // ⚠️ !! Ativado somente em modo debug !! ⚠️ 
                .EnableSensitiveDataLogging()
        );

#elif (RELEASE)
        services.AddDbContextPool<EFContext>(options =>
                           options
                           .UseNpgsql(connectionString)
                           .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                   );
#endif
        services.AddScoped<EFContext>();
        return services;
    }

    public static IApplicationBuilder ConfigureMigration(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
        var context = serviceScope?.ServiceProvider.GetRequiredService<EFContext>();
        context?.Database.Migrate();

        return app;
    }
}
