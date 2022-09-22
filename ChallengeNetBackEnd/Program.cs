using ChallengeNetBackEnd.Data.Implementations;
using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Utils.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IDataContext, DataContext>();
builder.Services.SetDatabaseConfig(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
