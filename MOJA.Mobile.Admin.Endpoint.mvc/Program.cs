using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Domain.Entities.Users;
using MOJA.MobileStore.Domain.Entities.Users.Admins;
using MOJA.MobileStore.Infrastructure.IdentityConfigs;
using MOJA.MobileStore.Infrastructure.Services.Persons.Commands.SignOutPerson;
using MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson;
using MOJA.MobileStore.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connctionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<IdentityDbContext>(option =>
{
    option.UseSqlServer(connctionString);
});
builder.Services.AddIdentity<Admin, IdentityRole>()
    .AddEntityFrameworkStores<IdentityDbContext>()
    .AddDefaultTokenProviders()
    .AddRoles<IdentityRole>()
    .AddErrorDescriber<CustomeIdentityErrors>();

builder.Services.Configure<IdentityOptions>(options =>
{
    //user
    options.User.RequireUniqueEmail=true;

    //lockout
    options.Lockout.MaxFailedAccessAttempts= 5;
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(10);

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan= TimeSpan.FromDays(5);
    options.SlidingExpiration = true;

    options.AccessDeniedPath = "/Account/AccessDenied";
    options.LoginPath = "/Account/SignIn";
    options.LogoutPath = "/Account/SingOut";
});
builder.Services.AddScoped<ISignInPersonService, SignInAdminService>();
builder.Services.AddScoped<ISignOutPersonService, SignOutAdminService>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
