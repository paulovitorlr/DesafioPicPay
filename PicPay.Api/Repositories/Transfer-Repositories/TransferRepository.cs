using PicPay.Api.Data;
using Microsoft.EntityFrameworkCore;
using PicPay.Api.Model;

namespace PicPay.Api.Repositories.Transfer_Repositories;

public class TransferRepository : ITransferRepository
{
    private readonly AppDbContext _context;

    public TransferRepository(AppDbContext context)
    {
        _context = context;
    }

    public User? GetById(int id)
    {
        return _context.Users.FirstOrDefault(user => user.Id == id);
    }
        
    public void UpdateBalances(User payer, User payee, decimal value)
    {
        payer.Balance -= value;
        payee.Balance += value;
        _context.SaveChanges();
    }
   
}

