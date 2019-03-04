using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollecterProject.Startup))]
namespace TrashCollecterProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
