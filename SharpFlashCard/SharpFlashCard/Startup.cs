using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharpFlashCard.Startup))]
namespace SharpFlashCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
