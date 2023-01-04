using Microsoft.EntityFrameworkCore;
using SquareOfOpposition.Web.Data;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SquareOfOppositionDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("SquareOfOppositionConnectionString")));

// Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<ISquareRepository, SquareRepository>();
builder.Services.AddTransient<IStateRepository, StateRepository>();

// Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
