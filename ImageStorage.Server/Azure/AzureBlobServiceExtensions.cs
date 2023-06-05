using Imazen.Common.Storage;

namespace ImageStorage.Server.Azure;

public static class AzureBlobServiceExtensions
{

    public static IServiceCollection AddImageflowAzureBlobService(this IServiceCollection services,
        AzureBlobServiceOptions options)
    {
        services.AddSingleton<IBlobProvider, AzureBlobService>();
        services.AddSingleton<AzureBlobServiceOptions>(options);

        return services;
    }


}