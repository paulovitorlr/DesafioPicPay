using Microsoft.EntityFrameworkCore;
using PicPay.Api.DTOs.DTO_Auth;
using PicPay.Api.DTOs.DTO_Trasnferencia;
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

    public void Register(RegisterDTO dto)
    {
        var emailVerify = _repository.GetByEmail(dto.Email);

        if (emailVerify != null)
        {
            throw new Exception("Email already registered.");
        }

        var documentVerify = _repository.GetByDocument(dto.Document);

        if (documentVerify != null)
        {
            throw new Exception("Document already registered.");
        }

        var typeDocument = DocumentType(dto.Document);

        var user = new User
        {
            FullName = dto.FullName,
            Email = dto.Email,
            Document = dto.Document,
            Password = dto.Password,
            DocumentType = typeDocument,
        };
        _repository.Create(user);
    }

    public bool Login(LoginDTO dto)
    {
        var user = _repository.GetByEmail(dto.Email);

        if (user == null) 
            return false;
        return user.Password == dto.Password;
    }

    private string DocumentType(string document)
    {
        document = document.Replace(".", "")
                           .Replace("-", "")
                           .Replace("/", "");
        if (document.Length == 11)
            return "CPF";
        if (document.Length == 14)
            return "CNPJ";

        throw new Exception("Invalid document.");
    }
}

