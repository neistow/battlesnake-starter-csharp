namespace Starter.Api;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(o => { o.OutputFormatters.Clear(); })
            .AddNewtonsoftJson(o => { o.UseCamelCasing(processDictionaryKeys: true); });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseStatusCodePages();

        app.UseRouting();

        app.UseCors(o => { o.AllowAnyOrigin(); });

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}