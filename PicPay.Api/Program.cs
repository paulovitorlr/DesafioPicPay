using Microsoft.EntityFrameworkCore;
using PicPay.Api.Data;
using PicPay.Api.Repositories;
using PicPay.Api.Repositories.Transfer_Repositories;
using PicPay.Api.Services.Auth_Services;
using PicPay.Api.Services.Transfer_Service;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Repository
builder.Services.AddSingleton<IAuthRepository, FakeUserRepository>();
builder.Services.AddSingleton<ITransferRepository, FakeTransferRepository>();

// Service
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddHttpClient<ITransferService, TransferService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();


app.UseHttpsRedirection();

app.MapControllers();

app.Run();