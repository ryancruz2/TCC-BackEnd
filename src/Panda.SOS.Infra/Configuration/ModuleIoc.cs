namespace Panda.SOS.Infra.Configuration;
public class ModuleIoc : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        Configloc.Load(builder);
    }
}
