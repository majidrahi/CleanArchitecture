using CleanArch.Infra.Data.Context;
using CleanArch.Mvc.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CleanArch.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var universityIdentityDBConnection = builder.Configuration.GetConnectionString("UniversityIdentityDBConnection");
var universityDBConnection = builder.Configuration.GetConnectionString("UniversityDBConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(universityIdentityDBConnection));

builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseSqlServer(universityDBConnection)
);

//DI
builder.Services.RegisterServices();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
