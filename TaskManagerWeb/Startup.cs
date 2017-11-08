using Microsoft.Owin.Hosting;
using Owin;


namespace Owin_Nancy
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
