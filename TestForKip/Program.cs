using TestForKip;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<MyDbContext>(
        options => options.UseNpgsql(builder.Configuration.GetConnectionString("PsqlConnectionString")));
builder.Services.AddScoped<DbContext, MyDbContext>();



var app = builder.Build();


app.UseAuthorization();

app.MapControllers();

app.Run();
