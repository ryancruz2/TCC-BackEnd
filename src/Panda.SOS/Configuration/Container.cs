using Autofac;
using Autofac.Extensions.DependencyInjection;
using Panda.SOS.Infra.Configuration;

namespace Panda.SOS.Configuration;

public static class Container
{
    public static IHostBuilder ConfigureModule(this IHostBuilder builder)
    {
        builder.UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(x => x.RegisterModule(new ModuleIoc()));
        return builder;
    }
}
