using Microsoft.AspNetCore.Mvc;
using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Services.Transferencia_Service;

namespace PicPay.Api.Controllers.controller_Transferencia;

[ApiController]
[Route("api/transfer")]
public class TransferController : ControllerBase
{
    private readonly ITransferService _transferService;

    public TransferController(ITransferService transferService)
    {
        _transferService = transferService;
    }

    [HttpPost("transferir")]
    public async Task<IActionResult> Transferir(TransferenciaDTO dto)
    {
        
    }
    

    //Criar os controllers, testar se consigo enviar/receber 
}

