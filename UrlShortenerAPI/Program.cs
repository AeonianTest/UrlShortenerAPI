var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi(); //Using open API for now
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "UrlShortenerAPI is running";
});

app.Run();