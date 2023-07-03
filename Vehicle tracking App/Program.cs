using Microsoft.EntityFrameworkCore;
using Vehicle_tracking_App;
using Vehicle_tracking_App.Data_Access;
using Vehicle_tracking_App.RepositoryPattern;

var builder = WebApplication.CreateBuilder(args);


var connectionstring = builder.Configuration.GetConnectionString("VehicalDatabase");
builder.Services.AddDbContext<VehicletrackingContext>(options => options.UseSqlServer(connectionstring));
// Add services to the container.
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserAppservices, UserAppService>();
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
