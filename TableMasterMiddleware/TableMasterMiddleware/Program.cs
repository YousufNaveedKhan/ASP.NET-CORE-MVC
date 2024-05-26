var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Multiplication of Table 2:\n");
    for (int i = 1; i <= 10; i++)
    {
        await context.Response.WriteAsync($"2 x {i} = {2 * i}\n");
    }

    await next();
});

app.Run();
