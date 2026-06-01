using PicPay.Api.Model;
using PicPay.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace PicPay.Api.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;

    public AuthRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(user  => user.Email == email);
    }

    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
       
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}

