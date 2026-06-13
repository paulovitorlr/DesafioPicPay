using PicPay.Api.Model;

namespace PicPay.Api.Repositories.Transfer_Repositories;

public class FakeTransferRepository : ITransferRepository
{
    private static readonly List<User> _users = new()
    {
        new User { Id = 1, FullName = "João Silva", Email = "mozartifreddy333@gmail.com", Document = "12345678901", Password = "123", DocumentType = "CPF", Balance = 100 },
        new User { Id = 2, FullName = "Maria Souza", Email = "maria@teste.com", Document = "98765432100", Password = "123", DocumentType = "CPF", Balance = 100 },
    };

    public User? GetById(int id) =>
        _users.FirstOrDefault(u => u.Id == id);

    public void UpdateBalances(User payer, User payee, decimal value)
    {
        payer.Balance -= value;
        payee.Balance += value;
    }
}