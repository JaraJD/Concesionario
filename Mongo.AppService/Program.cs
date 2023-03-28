using AutoMapper.Data;
using Mongo.DrivenAdapter.Interfaces;
using Mongo.DrivenAdapter;
using Mongo.AppService.Automapper;
using Domain.UseCases.Gateway;
using Domain.UseCases.UseCases;
using Domain.UseCases.Gateway.Repository;
using Mongo.DrivenAdapter.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(config => config.AddDataReaderMapping(), typeof(ConfigurationProfile));
builder.Services.AddSingleton<IContext>(provider => new Context(builder.Configuration.GetConnectionString("DefaultConnection"), "ConcesionarioAutos"));

builder.Services.AddScoped<IMarcaUseCase, MarcaUseCase>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();

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
