

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages support
builder.Services.AddRazorPages();

var app = builder.Build();

// Enable static files (css, js)
app.UseStaticFiles();

// Enable Razor Pages routing
app.MapRazorPages();

// Start the web app
app.Run();



