using EFDataAccessLib.DataAccess;
using FiscalService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

bool isProduction = false;


if (isProduction)
{

    Console.WriteLine("--> Using SQL Server DB");
    IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Production.json").Build();
    Console.WriteLine($"Connection string: {configuration["ConnectionString:PlatformsConn"]}");
    builder.Services.AddDbContext<DataContext>(opt =>
        opt.UseSqlServer(configuration["ConnectionString:PlatformsConn"]));
}
else
{
    Console.WriteLine("--> Using InMem DB");
    IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
    builder.Services.AddDbContext<DataContext>(opt => 
        opt.UseInMemoryDatabase("InMem")); 
}

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
