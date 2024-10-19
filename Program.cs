using System.Security.Claims;
using ANetCoreAngularAuth;
using ANetCoreAngularAuth.Endpoints;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication("cookie")
    .AddCookie("cookie");

builder.Services.AddAuthorization();

var app = builder.BuildWithSpa();

var apiEndpoints = app.MapGroup("/api");

apiEndpoints.MapGet("/user", UserEndpoint.Handler);

apiEndpoints.MapPost("/login", LoginEndpoint.Handler);

apiEndpoints.MapPost("/register", () => "todo");
apiEndpoints.MapGet("/logout", LogoutEndpoint.Handler).RequireAuthorization();

app.Run();

public class LoginForm
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
