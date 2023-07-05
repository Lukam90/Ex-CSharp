using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

using BlazorCourse;
using BlazorCourse.Data.Contexts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Adding Database
builder.Services.AddDbContext<DeveloperDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
