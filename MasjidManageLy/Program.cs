using MasjidManageLyRepository.DbConfigure;
using MasjidManageLyRepository.InterfaceRepository;
using MasjidManageLyRepository.Repository;
using MasjidManageLyService.InterfaceService;
using MasjidManageLyService.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MasjidDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MasjidManageLyDb")));

builder.Services.AddScoped<IVolunteerRepository, VolunteerRepository>();

builder.Services.AddScoped<IVolunteerService, VolunteerService>();


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
