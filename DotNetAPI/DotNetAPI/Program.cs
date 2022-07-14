var builder = WebApplication.CreateBuilder(args);

// Services //

builder.Services.AddControllers();

var app = builder.Build();

// Pipeline //

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin => true).AllowCredentials());
}

app.UseAuthorization();

app.MapControllers();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapFallbackToFile("{*path:regex(^(?!api[/].+))}", "index.html");
});

app.Run();