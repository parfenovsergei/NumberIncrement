using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NumberIncrementAPI.AutoMapper.NumberAutoMapper;
using NumberIncrementAPI.DAL;
using NumberIncrementAPI.DAL.Interfaces;
using NumberIncrementAPI.DAL.Repositories;
using NumberIncrementAPI.Models;
using NumberIncrementAPI.Services.Implementations;
using NumberIncrementAPI.Services.Interfaces;

var numberOrigins = "NumberOrigins";
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped<IBaseRepository<Number>, NumberRepository>();
builder.Services.AddScoped<IIncrementService, IncrementService>();
builder.Services.AddScoped<INumberAutoMapper, NumberAutoMapper>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var frontUrl = builder.Configuration.GetSection("FrontURL")["Url"];
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: numberOrigins,
                      policy =>
                      {
                          policy.WithOrigins(frontUrl).AllowAnyHeader().AllowAnyMethod();
                      });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(numberOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
