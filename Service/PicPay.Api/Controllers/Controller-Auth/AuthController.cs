using Microsoft.AspNetCore.Mvc;
using PicPay.Api.DTOs.DTO_Auth;
using PicPay.Api.Services.Auth_Services;

namespace PicPay.Api.Controllers.Controller_Auth;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDTO dto)
    {
        var resultado = await _authService.RegisterAsync(dto);
        if (!resultado)
            return BadRequest("Email já cadastrado");

        return Ok("Usuário registrado com sucesso.");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO dto)
    {
        var usuario = await _authService.LoginAsync(dto);

        if (usuario == null)
            return BadRequest("Email ou senha invalidos.");
        return Ok(usuario);
    }
}