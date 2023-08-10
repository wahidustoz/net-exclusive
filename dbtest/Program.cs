using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options 
    => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

var app = builder.Build();

app.Run();