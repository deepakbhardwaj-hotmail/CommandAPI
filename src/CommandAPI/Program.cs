using CommandAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<CommandContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnStr")));
builder.Services.AddScoped<ICommandAPIRepo, SQLCommandAPIRepo>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
