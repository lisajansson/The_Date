using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Date.Startup))]
namespace The_Date
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
