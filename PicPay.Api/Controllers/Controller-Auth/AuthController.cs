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
        
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO dto)
    {
        
    }
}