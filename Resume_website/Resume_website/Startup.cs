using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resume_website.Startup))]
namespace Resume_website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
