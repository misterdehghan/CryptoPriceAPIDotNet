using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface ICoinMarketCapClient
    {
        Task<decimal> GetPriceAsync(string cryptoCode);

    }
}
