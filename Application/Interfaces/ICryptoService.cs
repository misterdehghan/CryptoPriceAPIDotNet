using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ICryptoService
    {
        Task<CryptoQuoteDto?> GetQuoteAsync(string cryptoCode);

    }
}
