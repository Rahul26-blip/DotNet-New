using INT.Applaction.Iservises;
using INT.Applaction.Servises;
using INT.Infrastucher.Context;
using INT.Infrastucher.IRepository;
using INT.Infrastucher.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IOwnerServises, OwnerServises>();
builder.Services.AddTransient<IOwnerRepository, OwnerRepository>();

builder.Services.AddDbContext<AppDbCntext>(options =>options.UseSqlServer
    (builder.Configuration.GetConnectionString("DbConnection")
 ));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
