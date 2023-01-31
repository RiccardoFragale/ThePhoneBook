using ThePhoneBook.Api;
using ThePhoneBook.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
bool.TryParse(builder.Configuration["UseMocks"], out var useMocks);
SharedLib.CommonConfigs(builder.Services, useMocks);
builder.Services.AddAutoMapper(typeof(ApiMappingProfile));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }