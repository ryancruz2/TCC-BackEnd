namespace Panda.SOS.Infra.Config;
public class ApiConfigService
{
    public readonly int Version;
    public ApiConfigService(IConfiguration config)
    {
        Version = int.Parse(config["version"]!);
    }
}
