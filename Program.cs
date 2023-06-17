var app = WebApplication.CreateBuilder(args).Build();

app.MapPost("/api/barcode", (string text) => {
    Console.WriteLine($"Text: {text}");
    return "cool!";
});

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run("https://0.0.0.0:5001");
