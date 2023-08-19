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

            app.UseOnUrl("/addauthors", async context=>
            {
                string content= "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <title>Add Authors</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\">\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js\"></script>\r\n    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js\"></script>\r\n</head>\r\n<body>\r\n\r\n    <div class=\"container\">\r\n        <h3>Add Author</h3>\r\n        <form action=\"\">\r\n            <div class=\"form-group\">\r\n                <input type=\"text\" class=\"form-control\" id=\"authorname\" placeholder=\"Enter Author Name\" name=\"authorName\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <textarea type=\"text\" class=\"form-control\" id=\"Biography\" placeholder=\"Enter Author's' Biography\" name=\"biography\"></textarea>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"file\" class=\"form-control\" id=\"authorPhoto\" accept=\"image/png, image/jpeg\" placeholder=\"Upload Author Photo\" name=\"authorPhoto\" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"email\" class=\"form-control\" id=\"authoremail\" placeholder=\"Enter Author email\" name=\"authorEmail\">\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default btn-success\">Submit</button>\r\n        </form>\r\n    </div>\r\n\r\n</body>\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
                context.Response.ContentType="text/html";
                await context.Response.WriteAsync(content);
            });

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
