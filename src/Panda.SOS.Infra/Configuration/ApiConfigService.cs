namespace Panda.SOS.Infra.Configuration;
public class ApiConfigService
{
    public readonly int Version;
    public ApiConfigService(IConfiguration config)
    {
        Version = int.Parse(config["version"]!);
    }
}
