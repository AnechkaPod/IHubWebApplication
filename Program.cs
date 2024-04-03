using IHubWebApplication;
using IHubWebApplication.BLL;
using IHubWebApplication.DAL;
using IHubWebApplication.JsonConverters;
using IHubWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Server.IISIntegration;
/*
!!!DO NOT DELETE THIS LINE!!!
//run clean
dotnet ef dbcontext scaffold "Server=localhost\SQLEXPRESS01;Database=Invest_Hub;Integrated Security=true;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --force --table TableName1 --table TableName2

dotnet ef dbcontext scaffold "Server=localhost\SQLEXPRESS01;Database=Invest_Hub;Integrated Security=true;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --force
dotnet ef dbcontext scaffold "Server=DESKTOP-6KCUQP6\SQLEXPRESS;Database=IHubWebApplicationContext-b59ddbde-0599-485c-928a-ee460f987da4;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model --force
dotnet ef dbcontext scaffold "Server=DESKTOP-6KCUQP6\SQLEXPRESS;Database=YourDatabase;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model --force --table YourTableName
!!!DO NOT DELETE THIS LINE!!!
*/
string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", $"log-{DateTime.Now:yyyy-MM-dd}.txt");
string logsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");




var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

if (!Directory.Exists(logsDirectory))
{
    Directory.CreateDirectory(logsDirectory);
}
using (StreamWriter writer = new StreamWriter(logFilePath, true))
{
    writer.WriteLine("connection string is: " + configuration.GetConnectionString("CrudConnection"));
}

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>

{
  //  options.JsonSerializerOptions.Converters.Add(new HgdrMutzarConverter());
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;

});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Retrieve connection string from appsettings.json
var connectionString = configuration.GetConnectionString("CrudConnection");




builder.Services.AddDbContext<InvestHubContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var allowedOrigin = configuration.GetValue<string>("Cors:AllowedOrigin");

using (StreamWriter writer = new StreamWriter(logFilePath, true))
{
    writer.WriteLine("Cors AllowedOrigin " + configuration.GetConnectionString("CrudConnection"));
}

builder.Services.AddCors(options =>
{
    //options.AddPolicy("CorsPolicy",
    //builder =>
    //{
    //    builder.WithOrigins(allowedOrigin)
    //           .AllowAnyHeader()
    //           .AllowAnyMethod()
    //           .AllowCredentials(); // Allow credentials (cookies, authorization headers, etc.)
    //});
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins(allowedOrigin)
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials(); // Allow credentials (cookies, authorization headers, etc.)
        });
});

builder.Services.AddScoped(typeof(CRUDService<>));
builder.Services.AddScoped(typeof(CRUDRepository<>));


builder.Services.AddScoped(typeof(HeshbonService));
builder.Services.AddScoped(typeof(HeshbonRepository));


builder.Services.AddScoped(typeof(MutzarService));
builder.Services.AddScoped(typeof(MutzarRepository));

builder.Services.AddAuthentication(IISDefaults.AuthenticationScheme);
builder.Services.AddAuthorization();

builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders(); // Remove other logging providers
    logging.AddNLog(); // UseNLog() for configuring NLog
});
var app = builder.Build();

// Configure CORS before other middleware
app.UseCors("AllowSpecificOrigin");

// Other middleware and configurations...

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();