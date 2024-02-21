using Kreta.HttpService.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Kreta.Desktop.Extensions
{
    public static class HttpServiceExtension
    {
        public static void ConfigureHttpService(this IServiceCollection services)
        {
            services.AddScoped<IAddressService,AddressService>();
        }
    }
}
