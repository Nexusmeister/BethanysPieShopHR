using BethanysPieShopHRM.App;
using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.App.State;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<ApplicationState>();

builder.Services.AddOidcAuthentication(opt =>
{
    builder.Configuration.Bind("Auth0", opt.ProviderOptions);
    opt.ProviderOptions.ResponseType = "code";
});

await builder.Build().RunAsync();
