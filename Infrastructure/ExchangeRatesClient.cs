using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class ExchangeRatesClient : IExchangeRatesClient
    {
        public async Task<Dictionary<string, decimal>> GetRatesAsync(List<string> currencies)
        {
            // TODO: با HttpClient به ExchangeRates API وصل شو
            // برای تست فعلاً مقدار ثابت می‌دهیم
            return new Dictionary<string, decimal>
            {
                ["USD"] = 1m,
                ["EUR"] = 0.92m,
                ["BRL"] = 5.1m,
                ["GBP"] = 0.78m,
                ["AUD"] = 1.55m
            };
        }
    }
}