using ContosoUniversity.Web;
using ContosoUniversity.Web.Services.Students;
using ContosoUniversity.Web.Store;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7018") });
builder.Services.AddScoped<IStudentState, StudentState>();

builder.Services.AddScoped<IStudentService, StudentService>();
await builder.Build().RunAsync();
