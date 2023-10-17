var builder = WebApplication.CreateBuilder(args);
//indicarle al servidor que utilizaremos la arquitectura de mvc
builder.Services.AddControllersWithViews();


var app = builder.Build();
//configuracion para utilizar rutas auth  y archivos estaticos.

app.UseStaticFiles(); // sirve para cargar los archivos staticos como css
app.UseRouting();
app.UseAuthorization();


app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
