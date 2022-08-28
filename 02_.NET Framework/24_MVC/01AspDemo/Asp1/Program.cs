var builder = WebApplication.CreateBuilder(args);

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
//pattern: "{controller=Home}/{action=welcome}/{id?}");

app.Run();

/*
    1. URL
    2. port

There are two way communication :
    either from controller to view 
or 
    from view to controller.

Model-->Controller-->View

HttpGet: Interface
HttpPost: ActionPerform---View
 */