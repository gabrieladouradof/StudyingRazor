var builder = WebApplication.CreateBuilder(args);

//adding razon in the configuration
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection(); // for running via https and avoiding error 400
app.UseStaticFiles(); // wwwroot, web standard

//for the assistant the creation of the routes and URLs
app.UseRouting();
app.MapRazorPages();

app.Run();
