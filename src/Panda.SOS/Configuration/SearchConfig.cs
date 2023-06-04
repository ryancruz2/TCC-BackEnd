using Azure;
using Microsoft.Extensions.Azure;
namespace Panda.SOS.Configuration;
public static class SearchConfig
{
    public static IServiceCollection ConfigureSearchService(this IServiceCollection services, IConfigurationSection section)
    {
        Uri endpoint = new Uri(section.GetValue<string>("EndPoint")!);
        string indexName = section.GetValue<string>("DefaultIndex")!;
        AzureKeyCredential key = new AzureKeyCredential(section.GetValue<string>("Key")!);

        services.AddAzureClients(builder =>
        {
            builder.AddSearchClient(endpoint, indexName, key);
            builder.AddSearchIndexClient(endpoint, key);
        });

        return services;
    }

}
