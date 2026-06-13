using PicPay.Api.Model;
using PicPay.Api.Repositories;

public class FakeUserRepository : IAuthRepository
{
    private readonly List<User> _users = new();

    public User? GetByEmail(string email)
    {
        return _users.FirstOrDefault(x => x.Email == email);
    }

    public User? GetByDocument(string document)
    {
        return _users.FirstOrDefault(x => x.Document == document);
    }

    public void Create(User user)
    {
        _users.Add(user);
    }
}