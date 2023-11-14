using IHubWebApplication;
using IHubWebApplication.BLL;
using IHubWebApplication.DAL;
using IHubWebApplication.JsonConverters;
using IHubWebApplication.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

/*
!!!DO NOT DELETE THIS LINE!!!
//run clean
dotnet ef dbcontext scaffold "Server=DESKTOP-6KCUQP6\SQLEXPRESS;Database=IHubWebApplicationContext-b59ddbde-0599-485c-928a-ee460f987da4;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model --force
dotnet ef dbcontext scaffold "Server=DESKTOP-6KCUQP6\SQLEXPRESS;Database=YourDatabase;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model --force --table YourTableName
!!!DO NOT DELETE THIS LINE!!!
*/

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>

{
   // options.JsonSerializerOptions.Converters.Add(new HgdrHeshbonConverter());
    options.JsonSerializerOptions.Converters.Add(new HgdrMutzarConverter());
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context>(options =>
{
    options.UseSqlServer("Server=DESKTOP-6KCUQP6\\SQLEXPRESS;Database=IHubWebApplicationContext-b59ddbde-0599-485c-928a-ee460f987da4;Integrated Security=true;Encrypt=False");
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
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
app.UseAuthorization();
app.MapControllers();

app.Run();