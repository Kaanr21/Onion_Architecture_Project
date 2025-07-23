using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddOpenApi();



var config = builder.Configuration.GetSection("Scalar");
bool openUI = config.GetValue<bool>("OpenScalarUIOnStart");
string routePrefix = config.GetValue<string>("RoutePrefix") ?? "scalar";
string appUrl = builder.Configuration["ASPNETCORE_URLS"] ?? "http://localhost:5000";

if (openUI)
{
    var url = $"{appUrl.TrimEnd('/')}/{routePrefix}";
    var psi = new System.Diagnostics.ProcessStartInfo
    {
        FileName = url,
        UseShellExecute = true
    };
    System.Diagnostics.Process.Start(psi);
}



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(opt =>
    {
        opt

            .WithTitle("Onion Architecture")
            .WithTheme(ScalarTheme.BluePlanet)
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient)

            ;
    });





}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
