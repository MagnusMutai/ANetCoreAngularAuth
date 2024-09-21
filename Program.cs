using ANetCoreAngularAuth;

var builder = WebApplication.CreateBuilder(args);
var app = builder.BuildWithSpa();

var apiEndpoints = app.MapGroup("/api");

apiEndpoints.MapGet("/", () => "Hello World!");

app.Run();
