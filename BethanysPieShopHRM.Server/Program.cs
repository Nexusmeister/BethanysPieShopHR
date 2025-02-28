using System;
using BethanysPieShopHRM.Server;
using BethanysPieShopHRM.Server.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

//services.AddScoped<HttpClient>(s =>
//{
//    var client = new HttpClient { BaseAddress = new System.Uri("https://localhost:44340/") };
//    //var client = new HttpClient();
//    //var client = new HttpClient { BaseAddress = new System.Uri("https://bethanyspieshophrmapi.azurewebsites.net/") }; 
//    return client;
//});

//services.AddScoped<IEmployeeDataService, MockEmployeeDataService>();
builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44340/");
});
builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44340/");
});

await builder.Build().RunAsync();