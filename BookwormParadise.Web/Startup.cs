using BookwormParadise.Web;

namespace BookwormParadise.Web
{
    public static class Startup
    {
        public static void ConfigureMiddelwares(this IApplicationBuilder app)
        {
            app.UseOnUrl("/greet", async context => await context.Response.WriteAsync("Hello World"));
            
            app.UseOnUrl("/", async context =>
                //Redirect to Home Page Here
                await context.Response.WriteAsync("Home Page")
            );

            app.Run(context =>
            {
                Console.WriteLine($"Default Hanlder Received Request for {context.Request.Path} ");
                string err = "404 Error Not Found";
                context.Response.ContentType = "text/HTML";
                return context.Response.WriteAsync($"<h2>{err}</h2> <h3>The requested url was not found : {context.Request.Path}</h3>");
            });
        }
    }
}
