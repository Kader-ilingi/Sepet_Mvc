using Microsoft.EntityFrameworkCore;
using Sepet_Mvc.Models.Northwind;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//get connectionstring
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//Adddbcontext
builder.Services.AddDbContext<NorthwindContext>(options=>options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//Static dosyalarýn kullanýmý
app.UseStaticFiles();


app.UseRouting();

//Kimliklendirme
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
