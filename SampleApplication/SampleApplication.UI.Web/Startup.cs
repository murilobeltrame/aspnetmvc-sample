using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleApplication.UI.Web.Startup))]
namespace SampleApplication.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
