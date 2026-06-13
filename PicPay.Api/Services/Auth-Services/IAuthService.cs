using PicPay.Api.DTOs.DTO_Auth;
using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Model;

namespace PicPay.Api.Services.Auth_Services;

public interface IAuthService
{
    void Register(RegisterDTO dto);
    bool Login(LoginDTO dto);
}

