using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryTestWeb.Startup))]
namespace RepositoryTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
