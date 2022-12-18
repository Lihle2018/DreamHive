using DreamHive.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<EmailService>();
builder.Services.AddScoped<FirebaseRealTimeServices>();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
