using System.IO;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecureMvcApp.Data;
using SecureMvcApp.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Database (configure appsettings.json: "DefaultConnection")
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity + Roles
builder.Services
.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
    options.User.RequireUniqueEmail = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// MVC
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new Microsoft.AspNetCore.Mvc.AutoValidateAntiforgeryTokenAttribute());
}
    );

builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(Path.Combine(builder.Environment.ContentRootPath, "Keys")));

builder.Services.ConfigureApplicationCookie(opts =>
{
    opts.LoginPath = "/Account/Login";
    opts.AccessDeniedPath = "/Error/AccessDenied";
});

var app = builder.Build();

// Seed roles and admin
using (var scope = app.Services.CreateScope())
{
    await IdentitySeeder.SeedAsync(scope);
}
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}


// Pipeline
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapDefaultControllerRoute();

await app.RunAsync();