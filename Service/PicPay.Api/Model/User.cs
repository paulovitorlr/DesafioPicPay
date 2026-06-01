
namespace PicPay.Api.Model;

public class User
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
   
}
