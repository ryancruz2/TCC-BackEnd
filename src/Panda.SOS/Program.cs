using Microsoft.ApplicationInsights.Extensibility;
var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureModule();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<TelemetryConfiguration>((o) => {
    o.TelemetryInitializers.Add(new AppInsightsTelemetryConfig());
});

var config = builder.Configuration;
var con = config.GetConnectionString("Postgres")!;
builder.Services.ConfigureDatabase(con);

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();
app.ConfigureMigration();
app.Run();
