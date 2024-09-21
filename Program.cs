using System.Security.Claims;
using ANetCoreAngularAuth;

var builder = WebApplication.CreateBuilder(args);
var app = builder.BuildWithSpa();

var apiEndpoints = app.MapGroup("/api");

apiEndpoints.MapGet("/user", (ClaimsPrincipal user) => 
    user.Claims.ToDictionary(x => x.Type, x => x.Value));

apiEndpoints.MapGet("/login", () => "Hello World!");
apiEndpoints.MapGet("/register", () => "Hello World!");

app.Run();
