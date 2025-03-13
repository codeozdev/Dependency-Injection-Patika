using DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<ITeacher, Teacher>();
builder.Services.AddScoped<ClassRoom>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// bir controller olustuurlmadan minimal olarak bilgi gosterilmistir
app.MapGet("/teacher", (ClassRoom classRoom) => Results.Ok((object?)classRoom.GetTeacherInfo()));

app.Run();