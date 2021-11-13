using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Conjure.NScribe.PermissionsSample.Areas.Identity;
using Conjure.NScribe.PermissionsSample.Data;
using Newtonsoft.Json;
using ConjureApp;
using Conjure.NScribe.PermissionsSample;
using Microsoft.AspNetCore.Authorization;

if (false)
{
    Console.WriteLine(foo.ns1.Foo1.NS);

    foreach (var p in new ApplicationPermissions().AllPermissions)
    {
        Console.WriteLine(p);
    }

    // var target = new Dictionary<string, object>();
    // string text;
    
    // text = File.ReadAllText("./conjure.nscribe/permissions.json");
    // JsonConvert.PopulateObject(text, target);
    // Console.WriteLine(JsonConvert.SerializeObject(target));

    // text = File.ReadAllText("./conjure.nscribe/permissions.yaml");
    // var yamlDeser = new YamlDotNet.Serialization.Deserializer();
    // target = yamlDeser.Deserialize<Dictionary<string, object>>(text);
    // Console.WriteLine(JsonConvert.SerializeObject(target));

    return;
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddAuthorization(configure =>
{
    configure.AddPolicy("secure1", policy =>
    {
        //policy.RequireClaim(IPermissionSet.PermissionClaimType); //, ApplicationPermissions.MyPermission1);
        policy.Requirements.Add(new PermissionRequirement());
    });
});
builder.Services.AddSingleton<IAuthorizationHandler, PermissionHandler>();

builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
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

app.UseAuthentication();
app.UseMiddleware<PermissionAuthorizationMiddleware>();
app.UseAuthorization();


app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
