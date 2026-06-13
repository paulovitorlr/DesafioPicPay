using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Model;

namespace PicPay.Api.Repositories;

public interface IAuthRepository
{
    User? GetByEmail(string email);
    User? GetByDocument(string document);
    void Create(User user);
    
}

