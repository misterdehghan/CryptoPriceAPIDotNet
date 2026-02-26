using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IExchangeRatesClient
    {
        Task<Dictionary<string, decimal>> GetRatesAsync(List<string> currencies);

    }
}
