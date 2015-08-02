using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoGameStorage.Startup))]
namespace VideoGameStorage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
