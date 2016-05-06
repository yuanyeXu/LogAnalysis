using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogAnalysis.MongoDB.Web.Startup))]
namespace LogAnalysis.MongoDB.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
