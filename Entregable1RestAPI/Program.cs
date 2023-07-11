using Entregable1RestAPI.Models;
using Microsoft.EntityFrameworkCore;

//Boilerplate de microsoft

var builder = WebApplication.CreateBuilder(args);

// Añado servicios

builder.Services.AddControllers();
builder.Services.AddDbContext<CustomersContext>(opt => opt.UseInMemoryDatabase("Customers"));
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
