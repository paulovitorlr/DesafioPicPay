using PicPay.Api.Enums;

namespace PicPay.Api.Model;

public class User
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; }
    public string Email { get; set; }
    public string Documento { get; set; }
    public string Senha { get; set; }
    public TipoUsuario TipoUsuario { get; set; }
    public decimal Saldo { get; set; }
}