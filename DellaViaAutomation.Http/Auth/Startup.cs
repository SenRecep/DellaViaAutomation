using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;

[assembly: OwinStartup(typeof(DellaViaAutomation.Http.Auth.Startup))]
namespace DellaViaAutomation.Http.Auth
{
    public class Startup : IStartup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration configuration = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(configuration);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(configuration);
        }
        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions oAuthAuthorizationServerOptions = new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(30),
                AllowInsecureHttp=true,
                Provider=new Provider()
            };
            app.UseOAuthAuthorizationServer(oAuthAuthorizationServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}