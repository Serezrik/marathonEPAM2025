using Epam.ItMarathon.ApiService.Api.Extension;
using Serilog;

var builder = WebApplication
    .CreateBuilder(args)
    .ConfigureApplicationBuilder();

var app = builder.Build();
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/" &&
        context.Request.Host.Host.Equals("backend.marathontest.pp.ua", StringComparison.OrdinalIgnoreCase))
    {
        context.Response.Redirect("/swagger");
        return;
    }

    await next();
});

try
{
    Log.Information("Starting host");
    app.Run();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}
