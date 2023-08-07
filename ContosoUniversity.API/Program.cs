using ContosoUniversity.API.Configurations;
using ContosoUniversity.Data.Context;
using ContosoUniversity.Shared.Common;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data.Core.Configuration;
using ContosoUniversity.API.Services.StudentService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContosoUniversityDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddFluentValidation();
builder.Services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();
builder.Services.AddCors(policy => policy.AddPolicy("CorsPolicy", opts => opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyHeader()));


builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();	

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("CorsPolicy");
app.AddGlobalErrorHandler();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
