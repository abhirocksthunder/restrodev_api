using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Configuration;
using RestroDevAPI.Models;
using Microsoft.EntityFrameworkCore;
using RestroDevAPI.Services;
using RestroDevAPI.Repository;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IMenuCategoryService, MenuCategoryService>();
builder.Services.AddTransient<IMenuCategoryRepository, MenuCategoryRepository>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<RestroDevContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("RestrodevConStr"))
    );
// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

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

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
