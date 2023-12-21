using productMicroservice.Data;
using productMicroservice.IoC.IoCApplication;
using productMicroservice.IoC.IoCTest;
using productMicroservice.Services;
using productMicroservice.Services.Interface;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

if(builder.Environment.IsEnvironment("Test"))
{
    builder.Services.ConfigureDBContextTest();
}
else
{
    builder.Services.ConfigureDBContext(configuration);
}

// Add services to the container.
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
