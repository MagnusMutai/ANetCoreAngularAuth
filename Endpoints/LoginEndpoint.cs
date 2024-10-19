using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace ANetCoreAngularAuth.Endpoints
{
    public class LoginEndpoint
    {
        public static IResult Handler(LoginForm loginForm) =>
            Results.SignIn(
                new ClaimsPrincipal(
                    new ClaimsIdentity(
                        new Claim[]
                        {
                            new Claim("user_id", Guid.NewGuid().ToString()),
                            new Claim("username", loginForm.UserName)
                        },
                        "cookie"
                    )
                ),
                properties: new AuthenticationProperties() { IsPersistent = true },
                authenticationScheme: "cookie"
                );
    }
}
