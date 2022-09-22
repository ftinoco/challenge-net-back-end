using ChallengeNetBackEnd.Data.Implementations;
using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Utils.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// injecting data context
builder.Services.AddScoped<IDataContext, DataContext>();
builder.Services.AddScoped<IUserQueries, UserQueries>();
// setting up database connection
builder.Services.SetDatabaseConfig(builder.Configuration);
// adding swagger
builder.Services.AddSwaggerGen();
// adding automapper injection
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
 
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        opt.RoutePrefix = string.Empty;
    });
}

app.Run();
