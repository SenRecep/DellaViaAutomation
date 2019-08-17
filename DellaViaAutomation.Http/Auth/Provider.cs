using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace DellaViaAutomation.Http
{
    public class Provider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.FromResult(context.Validated());
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin",new[] { "*" });
            if (context.UserName=="recep" && context.Password=="pecer")
            {
                var identiy = new ClaimsIdentity(context.Options.AuthenticationType);
                identiy.AddClaim(new Claim("name",context.UserName));
                identiy.AddClaim(new Claim("role","Admin"));
                AuthenticationTicket ticket = new AuthenticationTicket(identiy,null);
                await Task.FromResult(context.Validated(ticket));
            }
            else
            {
                context.SetError("Geçersiz istek","Hatalı kullanıcı bilgisi");
            }
        }
    }
}