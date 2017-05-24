using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkScheduleWeb.Startup))]
namespace WorkScheduleWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
