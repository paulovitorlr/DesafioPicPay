
namespace PicPay.Api.Model;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }
    public string Password { get; set; }
    public string DocumentType { get; set; }

    public decimal Balance { get; set; } = 100;
}