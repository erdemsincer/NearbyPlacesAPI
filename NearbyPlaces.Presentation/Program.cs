using Microsoft.EntityFrameworkCore;
using NearbyPlaces.Infrastructure.Persistence;
using NearbyPlaces.Infrastructure.DependencyInjection;
using NearbyPlaces.Application.Common;
using MediatR;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddInfrastructureServices();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddMediatR(typeof(MappingProfile).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
