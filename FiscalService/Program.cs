using FiscalService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var sqlConnBuilder = new SqlConnectionStringBuilder();
sqlConnBuilder.ConnectionString = builder.Configuration.GetConnectionString("SQLDBConnection");


Console.WriteLine("--> Using SQL Server DB");
// IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Production.json").Build();
// Console.WriteLine($"Connection string: {configuration["ConnectionString:PlatformsConn"]}");
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer(sqlConnBuilder.ConnectionString));


var app = builder.Build();

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
