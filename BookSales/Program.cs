using BookSales.Data;
using BookSales.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



//DbContext for SQL
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));


//Services will be added
builder.Services.AddScoped<IPrintHousesService, PrintHousesService>();
builder.Services.AddScoped<ITranslatorsService, TranslatorsService>();
builder.Services.AddScoped<IAuthorsService, AuthorsService>();



//Configuration for Password will be added



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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
