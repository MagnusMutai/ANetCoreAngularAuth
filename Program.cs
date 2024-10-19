using System.Security.Claims;
using ANetCoreAngularAuth;
using ANetCoreAngularAuth.Endpoints;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication("cookie")
    .AddCookie("cookie");

var app = builder.BuildWithSpa();

var apiEndpoints = app.MapGroup("/api");

apiEndpoints.MapGet("/user", UserEndpoint.Handler);

apiEndpoints.MapGet("/login", LoginEndpoint.Handler);

apiEndpoints.MapGet("/register", () => "todo");
apiEndpoints.MapGet("/logout", () => Results.SignOut(authenticationSchemes: new List<string> {"cookie"}));

app.Run();

public class LoginForm
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
