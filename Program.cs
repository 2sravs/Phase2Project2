﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPIProject1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebProject1DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebProject1DbContext") ?? throw new InvalidOperationException("Connection string 'WebProject1DbContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();