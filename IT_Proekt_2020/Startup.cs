using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Proekt_2020.Startup))]
namespace IT_Proekt_2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
