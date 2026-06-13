
using Microsoft.AspNetCore.Mvc;
using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Services.Transfer_Service;

namespace PicPay.Api.Controllers.Controller_Transfer;

[ApiController]
[Route("api/transfer")]
public class ControllerTransfer : ControllerBase
{
    private readonly ITransferService _TransferService;

    public ControllerTransfer(ITransferService TransferService)
    {
        _TransferService = TransferService;
    }

    [HttpPost]
    public async Task<IActionResult> Transfer(TransferDTO dto)
    {
        await _TransferService.Transfer(dto);
        return Ok("Transfer completed sucessfully");
    }
}

