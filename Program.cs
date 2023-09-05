using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppAssesment_18.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Assesment_18DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Assesment_18DbContext") ?? throw new InvalidOperationException("Connection string 'Assesment_18DbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
