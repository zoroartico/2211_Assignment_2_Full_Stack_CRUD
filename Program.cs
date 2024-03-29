using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using _2211_Assignment_2_Full_Stack_CRUD.Models;
/****************************************
 * CPRO 2211 C# Web Apps Assignment 2   *
 * Instructed By M. Raza                *
 * Application Developed Using In-Class *
 * Notes and Teachings as Reference     *
 * By Kaden de Frece - 000364780        *
 * **************************************/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add EF core Dependency Injection
builder.Services.AddDbContext<ContactContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ContactContext")
        )
    );

//Setting lowercase urls
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern:
            "{controller=Home}/{action=Index}/{id?}/{slug?}");
});


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
