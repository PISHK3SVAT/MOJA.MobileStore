using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Domain.Entities.Users;
using MOJA.MobileStore.Infrastructure.IdentityConfigs;
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
builder.Services.AddIdentity<Person, IdentityRole>()
    .AddEntityFrameworkStores<IdentityDbContext>()
    .AddDefaultTokenProviders()
    .AddErrorDescriber<CustomeIdentityErrors>();

builder.Services.AddScoped<ISignInPersonService, SignInPersonService>();

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
