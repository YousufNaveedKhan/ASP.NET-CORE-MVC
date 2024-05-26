var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome");
app.MapGet("/home" () => "This is Home page");
app.MapGet("/about" () => "This is About page");
app.MapGet("/contact" () => "Contact us at contact@example.com");

app.Run();
