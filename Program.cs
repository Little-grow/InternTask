using Microsoft.OpenApi.Models;
using Task.Models;
using Task.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Program API",
        Description = "An ASP.NET Core Web API for managing Program Internship"
    });
});

builder.Services.AddScoped<IProgramRepository, ProgramRepository>();
builder.Services.AddScoped<IBaseRepository<ApplicationForm>,ApplicationFormRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();


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
