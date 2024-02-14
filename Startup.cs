using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using _2211_Assignment_2_Full_Stack_CRUD.Models;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRouting(options =>
        {
            //Sets lowercase urls for standard url convention
            options.LowercaseUrls = true;
            options.AppendTrailingSlash = true;
        });
        services.AddDbContext<ContactContext>(options =>
        options.UseSqlServer(
        Configuration.GetConnectionString("ContactContext")));
    }
}