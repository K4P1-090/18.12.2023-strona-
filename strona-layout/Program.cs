using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDirectoryBrowser();
var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();
app.UseDefaultFiles();
app.UseFileServer(enableDirectoryBrowsing: true);
// app.MapGet("/", () => "Hello World!");

app.Run();
