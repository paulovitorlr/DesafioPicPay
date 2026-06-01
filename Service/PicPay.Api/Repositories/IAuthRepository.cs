using PicPay.Api.Model;

namespace PicPay.Api.Repositories;

public interface IAuthRepository
{
    Task<User?> GetByEmailAsync(string email);
    Task AddAsync(User user);
    Task SaveChangesAsync();
}

