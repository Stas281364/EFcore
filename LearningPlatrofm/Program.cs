

using LearningPlatform.DataAccess.Postgres;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


//регистрируем наш DbCotext
builder.Services.AddDbContext<LearningDbContext>(Options =>
{
    Options.UseNpgsql(configuration.GetConnectionString(nameof(LearningDbContext)));
    //Options.UseNpgsql("Host = localhost; Port = 5432; Database = usersdb; Username = postgres; Password = 123");
});

var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.Run();
