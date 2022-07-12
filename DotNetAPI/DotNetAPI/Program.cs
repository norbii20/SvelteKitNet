var builder = WebApplication.CreateBuilder(args);

// Services //

builder.Services.AddControllers();

var app = builder.Build();

// Pipeline //

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();