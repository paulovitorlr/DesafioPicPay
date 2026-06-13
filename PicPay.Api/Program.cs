using Microsoft.EntityFrameworkCore;
using PicPay.Api.Data;
using PicPay.Api.Repositories;
using PicPay.Api.Repositories.Transfer_Repositories;
using PicPay.Api.Services.Auth_Services;
using PicPay.Api.Services.Transferencia_Service;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("PicPayDb"));

// Injeção de dependência
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddScoped<ITransferService, TransferService>();
builder.Services.AddScoped<ITransferRepository, TransferRepository>();


var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();