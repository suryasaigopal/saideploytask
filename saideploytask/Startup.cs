using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(saideploytask.Startup))]
namespace saideploytask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
