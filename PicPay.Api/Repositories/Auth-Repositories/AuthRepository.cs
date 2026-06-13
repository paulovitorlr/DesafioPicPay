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

    User? GetByEmail(string email)
    {
        return _context.Users.FirstOrDefault(user  => user.Email == email);
    }
    User? GetByDocument(string document) 
    {
        return _context.Users.FirstOrDefault(user =>user.Document == document);
    }
    public void Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

}

