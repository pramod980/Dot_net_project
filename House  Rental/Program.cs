 using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using House__Rental.Data;
using House__Rental.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("House__RentalContextConnection") ?? throw new InvalidOperationException("Connection string 'House__RentalContextConnection' not found.");

builder.Services.AddDbContext<HouseRentalContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<HouseRentalUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<HouseRentalContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
