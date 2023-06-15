using ClassRoom.Context;
using Microsoft.EntityFrameworkCore;
using Serilog;
using TelegramSink;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=bizcom_;" +
                         "User Id=bizcom_; Password=asd123;TrustServerCertificate=True");
});



Log.Logger = new LoggerConfiguration()
    .WriteTo.TeleSink("6152241453:AAGFm6_JxkQDoKhiY1bQO2x3D-40Jv3ug8Y", "-1001931103469",
        minimumLevel: Serilog.Events.LogEventLevel.Information)
    .CreateLogger();



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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
