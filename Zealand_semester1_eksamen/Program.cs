

using hillerodSejlklubb.Services;
using Zealand_semester1_eksamen.SJS;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages support
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IBoatServiceSJS, BoatServiceSJS>();
builder.Services.AddSingleton<BookingService>();
var app = builder.Build();

// Enable static files (css, js)
app.UseStaticFiles();

// Enable Razor Pages routing
app.MapRazorPages();

// Start the web app
app.Run();



