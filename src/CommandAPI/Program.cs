using CommandAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<CommandContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnStr")));
builder.Services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
