using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddJsonConsole();

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/fetch", async (context) => {
    var respondingWith = "Base";
    await context.Response.WriteAsync(respondingWith);
});

app.MapPost("/create", async (context) => {
    context.Response.Headers.Append("Content-Type", "application/json");

    var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
    
    var jsonData = JsonSerializer.Deserialize<Dictionary<string, string>>(requestBody);

    if (jsonData == null) {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync(JsonSerializer.Serialize(new { error = "Invalid JSON" }));
        return;
    }

    await context.Response.WriteAsync(JsonSerializer.Serialize(jsonData));
});

app.Run();
