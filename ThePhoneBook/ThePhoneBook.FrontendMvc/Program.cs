using ThePhoneBook.FrontendMvc;
using ThePhoneBook.FrontendMvc.Controllers;
using ThePhoneBook.FrontendMvc.Features;
using ThePhoneBook.FrontendMvc.Interfaces;
using ThePhoneBook.FrontendMvc.Mappers;
using ThePhoneBook.FrontendMvc.Mocks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IFetchContactsQueryFeature, FetchContactsQueryFeature>();
builder.Services.AddTransient<IUnitFetchContacts, UnitFetchContactsMock>();
builder.Services.AddTransient<IMapperWrapper, AutoMapperExternal>();
builder.Services.AddTransient(typeof(ICustomMapper<,>), typeof(CustomMapper<,>));

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