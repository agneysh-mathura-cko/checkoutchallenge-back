using CKOChallenge2.Domain;
using CKOChallenge2.Domain.Services;
using CKOChallenge2.Mappers;
using CKOChallenge2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<IResponseMapper, ResponseMapper>();
builder.Services.AddSingleton<IRequestMapper, RequestMapper>();
builder.Services.AddSingleton<IPaymentService, PaymentService>();
builder.Services.AddSingleton<IPaymentGatewayService, PaymentGatewayService>();
builder.Services.AddSingleton<IDecryptionService, DecryptionService>();
builder.Services.AddSingleton<IPaymentGatewayService, PaymentGatewayService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();


builder.Services.AddCors(o => o.AddPolicy("AllowAnyOrigin",
    builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}



// app.UseHttpsRedirection();

app.UseCors("AllowAnyOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();