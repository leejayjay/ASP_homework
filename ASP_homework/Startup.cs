using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_homework.Startup))]
namespace ASP_homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
