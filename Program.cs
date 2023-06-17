var hashset = new HashSet<string>(); // globals <3
var app = WebApplication.CreateBuilder(args).Build();

app.Map("/count", () => hashset.Count);
app.Map("/add", (string text) => hashset.Add(text));

app.Map("/write", async () => {
    var writer = File.CreateText("qr-codes.txt");
    foreach (var code in hashset)
        await writer.WriteLineAsync(code);
    await writer.FlushAsync();
    writer.Close();
});

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run("https://0.0.0.0:5001");
