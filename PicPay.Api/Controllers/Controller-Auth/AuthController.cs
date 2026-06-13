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
    public IActionResult Register(RegisterDTO dto)
    {
        _authService.Register(dto);

        return Ok("User created succesfully");
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDTO dto)
    {
        _authService.Login(dto);

        return Ok("Welcome Back!");
    }
}