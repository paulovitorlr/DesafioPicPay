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

   
}

