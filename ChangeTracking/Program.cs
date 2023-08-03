using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

var app = builder.Build();

app.MapPost("api/students", async (PostStudentDto dto, AppDbContext dbContext, ILogger<Program> logger) =>
{
    dbContext.Students.Add(new Student()
    {
        Name = dto.Name,
        Birthday = dto.Birthday,
        CreatedAt = DateTime.UtcNow,
        ModifiedAt = DateTime.UtcNow
    });

    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);
    await dbContext.SaveChangesAsync();
    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);

    return Results.Ok();
});

app.MapGet("api/students", async (AppDbContext dbContext, ILogger<Program> logger) =>
{
    var students = await dbContext.Students
        // .AsNoTracking()
        .Select(s => new 
        {
            Id = s.Id,
            Name = s.Name,
            Birthday = s.Birthday,
            CreatedAt = s.CreatedAt,
            ModifiedAt = s.ModifiedAt
        })
        .ToListAsync();

    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);

    return Results.Ok(students);
});

app.MapPut("api/students/{id}", async (int id, PutStudentDto dto, AppDbContext dbContext, ILogger<Program> logger) =>
{
    var student = await dbContext.Students
        .FirstOrDefaultAsync(s => s.Id == id);

    student.Name = dto.Name;
    student.Birthday = dto.Birthday;
    // student.ModifiedAt = DateTime.UtcNow;

    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);
    await dbContext.SaveChangesAsync();
    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);

    return Results.Ok();
});

app.MapPut("api/students/{id}/noread", async (int id, PutStudentDto dto, AppDbContext dbContext, ILogger<Program> logger) =>
{
    dbContext.Students.Update(new Student
    {
        Id = id,
        Name = dto.Name,
        Birthday = dto.Birthday
    });

    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);
    await dbContext.SaveChangesAsync();
    logger.LogInformation(dbContext.ChangeTracker.DebugView.LongView);

    return Results.Ok();
});

app.Run();