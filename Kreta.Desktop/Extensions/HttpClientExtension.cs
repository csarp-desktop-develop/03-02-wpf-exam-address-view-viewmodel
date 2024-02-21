using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kreta.Desktop.Extensions
{
    public static class HttpClientExtension
    {
        public static void ConfigureHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient(
                "KretaApi", 
                options => options.BaseAddress = new Uri("https://localhost:7090/"
                ));
        }
    }
}
