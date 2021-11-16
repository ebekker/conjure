using Conjure.BlazorKit.Data;
using ConjureApp.Data;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;
using MudBlazorUI.Sample1.Data;

namespace MudBlazorUI.Sample1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddMudServices();

            services.AddDbContext<AdventureWorksLT2017Context>(options =>
            {
                //options.UseSqlServer();
            });
            services.AddTransient<DataWorkspace>();
            //services.AddTransient<DataWorkspaceBase, DataWorkspace>();

            services.AddBlazorKit(() => new()
            {
                AppTitle = "Sample #1",
                AppVersion = typeof(Startup).Assembly.GetName().Version?.ToString() ?? "n/a",
                Menu = new("")
                {
                    Children = new NavMenuItem[]
                    {
                        new NavMenuItem("Home")
                        {
                            Icon = Icons.Material.Outlined.Home,
                            Href = "/",
                        },

                        new NavMenuGroup("Classic")
                        {
                            Children = new NavMenuItem[]
                            {
                                new NavMenuItem("Counter")
                                {
                                    Icon = Icons.Material.Filled.Add,
                                    Href = "/counter",
                                },
                                new NavMenuItem("Fetch Data")
                                {
                                    Icon = Icons.Material.Filled.List,
                                    Href = "/fetchdata",
                                },
                            },
                        },

                        new NavMenuGroup("Test")
                        {
                            Icon = Icons.Material.Filled.Science,
                            Children = new NavMenuItem[]
                            {
                                new ScreenMenuItem<Pages.Test1>
                                {
                                    Icon = Icons.Custom.Uncategorized.Radioactive,
                                },
                                new ScreenMenuItem<Pages.Test2Even>
                                {
                                    Icon = Icons.Material.Filled.AvTimer,
                                    ComputeCanExecute = app => Pages.Test2Even.ComputeCanExecute(),
                                },
                                new ScreenMenuItem<Pages.Test2Odd>
                                {
                                    Icon = Icons.Material.Filled.AvTimer,
                                    ComputeCanExecute = app => Pages.Test2Odd.ComputeCanExecute(),
                                },
                                new ScreenMenuItem<Pages.Test3>
                                {
                                    Icon = Icons.Custom.Uncategorized.Radioactive,
                                },
                                new ScreenMenuItem<Pages.Test4>
                                {
                                    Icon = Icons.Custom.Uncategorized.Radioactive,
                                    Label = "Test4 - DataList w/ Local",
                                },
                                new ScreenMenuItem<Pages.Test5>
                                {
                                    Icon = Icons.Custom.Uncategorized.Radioactive,
                                    Label = "Test5 - DataList w/ EFCore",
                                },
                                new ScreenMenuItem<Pages.Test6>
                                {
                                    Icon = Icons.Custom.Uncategorized.Radioactive,
                                },

                                new ScreenMenuItem<Pages.Test99>
                                {
                                    Icon = Icons.Custom.Uncategorized.Radioactive,
                                },
                            },
                        },
                    },
                }
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
