using Golfscorecard.DAL.Data;
using Golfscorecard.DAL.Interface;
using Golfscorecard.DAL.Interface.Implementation;
using GolfScorecard.BL.Interface;
using GolfScorecard.BL.Interface.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DI
builder.Services.AddDbContext<GolfScoreDBContext>();
builder.Services.AddScoped<IScorecard, ScorecardRepo>();
builder.Services.AddScoped<IScorecardService, ScorecardService>();

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
    pattern: "{controller=Scorecards}/{action=Index}/{id?}");

app.Run();
