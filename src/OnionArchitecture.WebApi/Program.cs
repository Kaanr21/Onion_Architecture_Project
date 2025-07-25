using OnionArchitecture.Persistance;
using OnionArchitecture.WebApi.Configurations;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddPersistanceRegistration(builder.Configuration);
builder.Services.ScalarApiRegistration(builder.Configuration);





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
