using CommandAPI.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();

        WebApplication app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        app.MapControllers();

        app.Run();
    }
}