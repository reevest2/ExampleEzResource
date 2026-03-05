using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GenEzResource.UI.Extensions;
using ExampleEzresource.Models;
using Radzen;
using ExampleEzresource;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddGenEzResourceUI(registry =>
{
    registry.AddResource<Customer>();
    registry.AddResource<Project>();
    registry.AddResource<TaskItem>();
});

builder.Services.AddRadzenComponents();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(App).Assembly));

await builder.Build().RunAsync();