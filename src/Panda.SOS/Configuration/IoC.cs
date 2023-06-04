using Panda.SOS.Services.Search;

namespace Panda.SOS.Configuration;

public static class IoC
{
    public static void ConfigureIoC(this IServiceCollection service)
    { 
        service.AddScoped<ISearchProvider<MobileCompanieIndex>, SearchProvider<MobileCompanieIndex>>();
    }
}
