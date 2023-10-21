using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BindAspGridView.Startup))]
namespace BindAspGridView
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
