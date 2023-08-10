using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication()
    .AddCookie("cookie", options => 
    {
        options.AccessDeniedPath = "/home";
        options.ExpireTimeSpan = TimeSpan.FromSeconds(10);
        options.Cookie.MaxAge = TimeSpan.FromSeconds(20);
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("admins-only", p =>
    {
        p.RequireClaim("role", "admin");
    });
});

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/login", async (string role, HttpContext ctx) => 
{
    var usernameClaim = new Claim("username", "wahid");
    var roleClaim = new Claim("role", role);

    var identity = new ClaimsIdentity(new List<Claim>{ usernameClaim, roleClaim }, "cookie");
    var user = new ClaimsPrincipal(identity);

    await ctx.SignInAsync("cookie", user);
});

app.MapGet("/secret", async (ctx) =>
{
    var user = ctx.User;

    await ctx.Response.WriteAsync(JsonSerializer.Serialize(user, new JsonSerializerOptions()
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    }));
}).RequireAuthorization();

app.MapGet("/admin", async (ctx) =>
{
    var user = ctx.User;

    await ctx.Response.WriteAsync(JsonSerializer.Serialize(user, new JsonSerializerOptions()
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    }));
}).RequireAuthorization("admins-only");

app.Run();

// var builder = WebApplication.CreateBuilder(args);

// var app = builder.Build();

// // Authentication middleware
// app.Use(async (ctx, next) => 
// {
//     if(ctx.GetEndpoint().DisplayName.Contains("login"))
//     {
//         await next();
//         return;
//     }

//     var usernameCookie = ctx.Request.Headers.Cookie.FirstOrDefault(c => c.Contains("username"));
//     if(usernameCookie is null)
//     {
//         ctx.Response.StatusCode = 401;
//         return;
//     }
    

//     var cookieParts = usernameCookie.Split("=");
//     var username = cookieParts[1];

//     if(username != "wahid")
//     {
//         ctx.Response.StatusCode = 403;
//         return;
//     }

//     await next();
// });

// app.MapGet("/secret", async (ctx) => 
// {
//     await ctx.Response.WriteAsync(ctx.Request.Headers.Cookie);
// });

// app.MapGet("/login", async (ctx) =>
// {
//     ctx.Response.Cookies.Append("username", "wahid");

//     await ctx.Response.WriteAsync("you are logged in");
// });

// app.Run();