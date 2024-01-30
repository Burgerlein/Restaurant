namespace restaurant.backend;

public class Startup
{
    private IServiceCollection _services { get; set; }

    public Startup(IServiceCollection services)
    {
        _services = services;
    }

    public void Execute()
    {
        AddServices();
    }

    private void AddServices()
    {
        _services.AddControllers().AddNewtonsoftJson(x =>
            x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        _services.AddEndpointsApiExplorer();
        _services.AddSwaggerGen();
        AddCustomCors();
        AddRepositories();
    }

    private void AddRepositories()
    {
    }


    private void AddCustomCors()
    {
        _services.AddCors(options =>
        {
            options.AddPolicy(name: "MyAllowSpecificOrigins",
                corsPolicyBuilder => { corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
        });
    }
}