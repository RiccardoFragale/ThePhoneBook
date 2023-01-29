using ThePhoneBook.Core;
using ThePhoneBook.Core.Features;
using ThePhoneBook.Core.Interfaces;
using ThePhoneBook.Core.Mappers;
using ThePhoneBook.Core.Mocks;
using ThePhoneBook.FrontendMvc;
using ThePhoneBook.FrontendMvc.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

SharedLib.CommonConfigs(builder.Services);

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