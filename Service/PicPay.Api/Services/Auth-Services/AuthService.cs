using PicPay.Api.DTOs.DTO_Auth;
using PicPay.Api.Repositories;
using PicPay.Api.Model;

namespace PicPay.Api.Services.Auth_Services;

public class AuthService : IAuthService
{
    private readonly IAuthRepository _repository;
    

    public AuthService(IAuthRepository repository)
    {
        _repository = repository;
    }
  
    public async Task<bool> RegisterAsync(RegisterDTO dto)
    {
        var existing = await _repository.GetByEmailAsync(dto.Email);
        if (existing != null) return false;

        var user = new User 
        {
            Email = dto.Email,
            Senha = dto.Senha,
        };
        
        await _repository.AddAsync(user);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<string?> LoginAsync(LoginDTO dto)
    {
        var user = await _repository.GetByEmailAsync(dto.Email);

        if (user == null)
            return null;

        if (user.Senha != dto.Senha)
            return null;

        return "Login realizado com sucesso";

    }
}

