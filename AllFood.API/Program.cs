using AllFood.DataBase.Context;
using AllFood.Infrastructure.Implementations.Login;
using AllFood.Infrastructure.Interfaces.Login;
using AllFood.UseCases.AutoMapping.Input;
using AllFood.UseCases.AutoMapping.Output;
using AllFood.UseCases.Dtos;
using AllFood.UseCases.Implementations;
using AllFood.UseCases.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Internal;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AllFoodContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version("7.0.0"))));

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<InputToEntityMapping>();
    cfg.AddProfile<EntityToOutputMapping>();
});

builder.Services.AddControllers();

//Add UseCase
builder.Services.AddScoped<ILoginUseCase, LoginUseCase>();

//addRepository
builder.Services.AddScoped<ILoginRepository, LoginRepository>();


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
