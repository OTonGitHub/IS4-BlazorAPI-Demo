using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRestaurantService, RestaurantService>();

var app = builder.Build();

app.MapControllers();
// app.MapGet("/", () => "Hello World!");

app.Run();
