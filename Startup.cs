using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3._1.Startup))]
namespace lab3._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
