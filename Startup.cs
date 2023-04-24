using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NhaHangHaiSan.Startup))]
namespace NhaHangHaiSan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
