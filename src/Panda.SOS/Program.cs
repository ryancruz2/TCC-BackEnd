var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureModule();

// Add services to the container.

builder.Services.ConfigureController();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureIoC();

builder.Services.Configure<TelemetryConfiguration>((o) => {
    o.TelemetryInitializers.Add(new AppInsightsTelemetryConfig());
});

var config = builder.Configuration;

builder.Services.AddControllers();
builder.Services.ConfigureSearchService(config.GetSection("AzureSearchSettings"));
builder.Services.ConfigureDatabase(config.GetConnectionString("Postgres")!);

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();
app.ConfigureMigration();
app.Run();