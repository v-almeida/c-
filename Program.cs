using Microsoft.EntityFrameworkCore;
using ExemploORM.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<UserDbContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 34))));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

