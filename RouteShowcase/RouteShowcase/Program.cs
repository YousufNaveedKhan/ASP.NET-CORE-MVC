var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "<h1>WELCOME</h1>");
app.MapGet("/home" () => "<h2>This is Home page</h2>");
app.MapGet("/about" () => "<h3>This is About page</h3>");
app.MapGet("/contact" () => "Contact us at <b>contact@example.com</b>");

app.Run();
