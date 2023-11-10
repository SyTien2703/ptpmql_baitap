using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using DemoMvc.Data; // Nó không biết thằng DemoMvc khai báo ở đâu để dùng, tìm chỗ để khai báo thằng DemoMvc là đc

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbcontext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."));
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
