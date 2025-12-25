using EmployeeManagement.BL;
using EmployeeManagement.DL;
using EmployeeManagement.DL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Scaffold-DbContext "Server=INRJNM0OFFLT041;Database=EmployeeManagement;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmployeeManagementContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpDBConnection")));

//builder.Services.AddScoped<EmployeeManagement.DL.ILogger, TextLog>();
builder.Services.AddScoped<ILogging, TextLog>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
