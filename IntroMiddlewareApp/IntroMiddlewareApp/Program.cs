var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<h1>My Introduction</h1>\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\nHello, My name is Yousuf Naveed.\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\nI'm from Karachi.\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\nI'm current pursuing a web development internship with CodSoft.\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\nI have a passion for creating interactive and responsive websites.\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\nI'm excited to learn and grow in the field of web development.\n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("\n<small><strong>Yousuf Naveed</strong></small>");
});

app.Run();
