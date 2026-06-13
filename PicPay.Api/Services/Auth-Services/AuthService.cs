using Microsoft.EntityFrameworkCore;
using PicPay.Api.DTOs.DTO_Auth;
using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Enums;
using PicPay.Api.Model;
using PicPay.Api.Data;
using PicPay.Api.Repositories;

namespace PicPay.Api.Services.Auth_Services;

public class AuthService : IAuthService
{
    private readonly IAuthRepository _repository;
    

    public AuthService(IAuthRepository repository)
    {
        _repository = repository;
    }
  
  
   
}

