using DBFirst_MySql2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//�]�w�s�u
builder.Services.AddDbContext<dbstudentsContext>(Options =>
    Options.UseMySql(builder.Configuration.GetConnectionString("DBConnectionStrings"),
    new MySqlServerVersion(new Version(8, 0, 33)))); // MySQL �������i�ھڹ�ڱ��p�վ�

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
