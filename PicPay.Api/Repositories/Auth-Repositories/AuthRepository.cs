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

  
    
}

