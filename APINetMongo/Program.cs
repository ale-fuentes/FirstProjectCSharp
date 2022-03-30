
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using APINetMongo.Models;
using APINetMongo.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<PeopleStoreDatabaseSettings>(builder.Configuration.GetSection(nameof(PeopleStoreDatabaseSettings)));
builder.Services.AddSingleton<IPeopleStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<PeopleStoreDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("PeopleStoreDatabaseSettings:ConnectionString")));
builder.Services.AddScoped<IPeopleService, PeopleService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
