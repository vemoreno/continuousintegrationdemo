using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureCloudService.Startup))]
namespace AzureCloudService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
