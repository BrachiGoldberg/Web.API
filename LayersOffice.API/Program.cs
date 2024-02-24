using LayersOffice.API.Middlewares;
using LayersOffice.Core;
using LayersOffice.Core.Repositories;
using LayersOffice.Core.Services;
using LayersOffice.Data;
using LayersOffice.Data.Reposirories;
using LayersOffice.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICostumerRepository, CostumerRepository>();
builder.Services.AddScoped<ICourtCaseRepository, CourtCaseRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepsitory>();

builder.Services.AddScoped<ICostumerService, CostumerService>();
builder.Services.AddScoped<ICourtCaseService, CourtCaseService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddDbContext<DataContext>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.RenovationMiddleware();

app.LoggerMiddleware();

app.MapControllers();

app.Run();
