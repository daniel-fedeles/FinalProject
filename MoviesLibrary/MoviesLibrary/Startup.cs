using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesLibrary.Startup))]
// [assembly: log4net.Config.XmlConfigurator(
//     ConfigFile = "log4net.Config",
//     Watch = true
// //, ConfigFileExtension = "log4net.Config"
// )]
namespace MoviesLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
