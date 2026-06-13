using PicPay.Api.DTOs.DTO_Trasnferencia;

namespace PicPay.Api.Services.Transfer_Service;

public interface ITransferService
{
    Task Transfer(TransferDTO dto);
}

