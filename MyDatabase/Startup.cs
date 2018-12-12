using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDatabase.Startup))]
namespace MyDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
