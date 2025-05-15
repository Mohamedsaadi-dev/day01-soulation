using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace project01_structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); 
            var app = builder.Build();
            app.UseRouting();   

          //  app.MapGet("/", () => "Hello World!");
          app.UseStaticFiles(); 
            app.MapControllerRoute(
                name: "defult",
                pattern: "{controller=HOME}/{action=INDEX}/{id:int?}"
                //defaults: new {Action = "Index",controller="movies"},
               // constraints: new { id =@"\d{ 2}" }
                );

            //app.MapGet("/index", () => "Hello from index");

            // app.MapGet("/{name}", async context =>
            // {
            //    var Name = context.GetRouteValue("name");
            //     await context.Response.WriteAsync($"helow{Name}");
            // });

            app.Run();
        }
    }
}
