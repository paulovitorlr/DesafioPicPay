using PicPay.Api.Model;

namespace PicPay.Api.Repositories.Transfer_Repositories;

public interface ITransferRepository
{
   User? GetById(int id);
    void UpdateBalances(User payer, User payee, decimal value);
}

