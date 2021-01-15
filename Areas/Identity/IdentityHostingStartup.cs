using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Asp.Saas.Areas.Identity.IdentityHostingStartup))]
namespace Asp.Saas.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}