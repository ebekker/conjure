using Microsoft.AspNetCore.Components;
using Conjure.Blazor.Sample1.Data;
using Conjure.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<ConjureInterop>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}


app.UseStaticFiles();

app.UseRouting();

// Adding to test access to local controllers
app.MapControllers();
//// Alt route
//app.MapControllerRoute("sample-alt", "api/sample-alt/{action}",
//    defaults: new { controller = "Sample" });
//app.MapControllerRoute("sample-alt2", "api/sample-alt/hello",
//    defaults: new { controller = "Sample", action = "hello" });

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
