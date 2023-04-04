using AlertmanagerWebhook;
using AlertmanagerWebhook.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IKavehNegarService,KavehNegarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


AppSettings.APIKey = Environment.GetEnvironmentVariable("APIKey");
AppSettings.Receptor = Environment.GetEnvironmentVariable("Receptor");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
