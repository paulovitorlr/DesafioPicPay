using Microsoft.EntityFrameworkCore;
using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Enums;
using PicPay.Api.Model;
using PicPay.Api.Repositories;
using PicPay.Api.Repositories.Transfer_Repositories;
using PicPay.Api.Services.Auth_Services;

namespace PicPay.Api.Services.Transferencia_Service;
public class TransferService : ITransferService
{
    private readonly ITransferRepository _TransferRepository;
    private readonly IAuthRepository _AuthRepository;

    

    public TransferService(ITransferRepository transferRepository, IAuthRepository authRepository)
    {
        _TransferRepository = transferRepository;
        _AuthRepository = authRepository;
    }

   
}

