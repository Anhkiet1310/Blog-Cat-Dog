using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IPetService, PetService>();
builder.Services.AddScoped<IPostService, PostService>();
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
