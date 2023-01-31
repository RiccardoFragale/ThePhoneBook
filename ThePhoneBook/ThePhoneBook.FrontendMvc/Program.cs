using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using ThePhoneBook.Core;
using ThePhoneBook.Data;
using ThePhoneBook.FrontendMvc;
using ThePhoneBook.FrontendMvc.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

bool.TryParse(builder.Configuration["UseMocks"], out var useMocks);

SharedLib.CommonConfigs(builder.Services, useMocks);

builder.Services.AddTransient<PhoneBookController>();

builder.Services.AddAutoMapper(typeof(FrontendMappingProfile));


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
    pattern: "{controller=PhoneBook}/{action=Index}/{id?}");

app.Run();

public partial class Program { }