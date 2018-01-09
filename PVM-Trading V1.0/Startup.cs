using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PVM_Trading_V1._0.Startup))]
namespace PVM_Trading_V1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
