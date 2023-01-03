using Microsoft.EntityFrameworkCore;
using Project.Dal;
using Project.Entity;
using Project.Repository.Abstracts;
using Project.Repository.Concretes;
using Project.UI.Models;
using Project.Uow;
using Project.UoW;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddDbContext<ProjectContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<IPersonelRep, PersonelRep<Personel>>();
builder.Services.AddScoped<Personel>();
builder.Services.AddScoped<PersonelModel>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
