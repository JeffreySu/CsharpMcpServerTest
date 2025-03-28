using ModelContextProtocol;
using AspNetCoreSseServer;
using CsharpMcpServerTest;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IColorService, ColorService>();

builder.Services.AddMcpServer().WithToolsFromAssembly();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapMcpSse();

app.Run();