global using CodeLogic;
using CL.SystemStats;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var systemStats = new Cpu().GetCpuUsage().ToString();

app.MapGet("/", () => systemStats);

app.Run();
