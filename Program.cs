using CarRentalAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register the DbContext with MySQL using Pomelo
builder.Services.AddDbContext<CarRentalDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("CarRentalDb"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("CarRentalDb"))
    ));

// Configure Swagger/OpenAPI
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
