using PicPay.Api.DTOs.DTO_Auth;

namespace PicPay.Api.Services.Auth_Services;

public interface IAuthService
{
    Task<bool> RegisterAsync(RegisterDTO dto);
    Task<string?> LoginAsync(LoginDTO dto);
}

