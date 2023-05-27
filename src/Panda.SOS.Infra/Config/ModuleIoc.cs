namespace Panda.SOS.Infra.Config;
public class ModuleIoc : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        Configloc.Load(builder);
    }
}
