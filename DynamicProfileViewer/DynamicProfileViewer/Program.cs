var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to Dynamic Profile Viewer App");

var profiles = new Dictionary<int, (string Name, string Email, int Age)>
    {
        { 101, ("Yousuf Naveed", "yousufnaveed@gmail.com", 21) },
        { 102, ("Muneeb Hassan", "mhs@gmail.com", 19) },
        { 103, ("Khuzaima Ahmed", "khuzaima@gmail.com", 24) },
        { 104, ("Huzaifa Iqbal", "huzaifa@gmail.com", 21) }
    };

app.MapGet("/home", () => "This is Home page");

app.MapGet("/home/{id:int}", (int id) =>
{
    if (profiles.TryGetValue(id, out var profile))
    {
        return Results.Json(new { profile.Name, profile.Email, profile.Age });
    }
    else
    {
        return Results.Json(new { Name = "Unknown", Email = "unknown@example.com", Age = 0 });
    }
});

app.Run();
