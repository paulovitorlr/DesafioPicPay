using PicPay.Api.DTOs.DTO_Trasnferencia;
using PicPay.Api.Repositories.Transfer_Repositories;

namespace PicPay.Api.Services.Transfer_Service;

public class TransferService : ITransferService
{
    private readonly ITransferRepository _repository;
    private readonly HttpClient _http;

    public TransferService(ITransferRepository repository, HttpClient http)
    {
        _repository = repository;
        _http = http;
    }

    public async Task Transfer(TransferDTO dto)
    {
        var payer = _repository.GetById(dto.Payer)
            ?? throw new Exception("Payer not found.");

        var payee = _repository.GetById(dto.Payee)
            ?? throw new Exception("Payee not found");

        if (payer.Balance < dto.Value)
            throw new Exception("Insufficient balance.");

        var auth = await _http.GetAsync("https://util.devi.tools/api/v2/authorize");

        if (!auth.IsSuccessStatusCode)
            throw new Exception("Transfer not authorized.");

        _repository.UpdateBalances(payer, payee, dto.Value);

        await _http.PostAsync("https://util.devi.tools/api/v1/notify", null);
    }

}

