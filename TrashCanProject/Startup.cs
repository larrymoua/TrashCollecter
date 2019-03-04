using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCanProject.Startup))]
namespace TrashCanProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
