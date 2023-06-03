

namespace Panda.SOS.Infra.Configuration;
public class Configloc
{
    public static void Load(ContainerBuilder builder)
    {
        builder.Register(context => new MapperConfiguration(mc => {
            mc.AddProfile(new MappingProfile());
        })).AsSelf().SingleInstance();

        builder.Register(c =>
        {
            var context = c.Resolve<IComponentContext>();
            var config = context.Resolve<MapperConfiguration>();
            return config.CreateMapper(context.Resolve);
        }).As<IMapper>()
        .InstancePerLifetimeScope();
    }
}
