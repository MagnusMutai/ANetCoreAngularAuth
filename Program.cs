using System.Security.Claims;
using ANetCoreAngularAuth;

var builder = WebApplication.CreateBuilder(args);

build.Services.AddAuthentication("cookie")
    .AddCookie("cookie");

var app = builder.BuildWithSpa();

var apiEndpoints = app.MapGroup("/api");

apiEndpoints.MapGet("/user", (ClaimsPrincipal user) => 
    user.Claims.ToDictionary(x => x.Type, x => x.Value));

// apiEndpoints.MapGet("/login", (LoginForm LoginForm) =>Results.SignIn (

// )

//  "Hello World!"{});

apiEndpoints.MapGet("/register", () => "Hello World!");

app.Run();

public class LoginForm
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
