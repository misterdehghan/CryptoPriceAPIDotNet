using Application.Dtos;
using Application.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class CryptoService:ICryptoService
    {
        private readonly ICoinMarketCapClient _coinClient;
        private readonly IExchangeRatesClient _exchangeClient;

        public CryptoService(ICoinMarketCapClient coinClient, IExchangeRatesClient exchangeClient)
        {
            _coinClient = coinClient;
            _exchangeClient = exchangeClient;
        }

        public async Task<CryptoQuoteDto?> GetQuoteAsync(string cryptoCode)
        {
            // اینجا قیمت پایه از CoinMarketCap می‌گیریم
            var priceUsd = await _coinClient.GetPriceAsync(cryptoCode);

            // نرخ تبدیل ارزها
            var rates = await _exchangeClient.GetRatesAsync(new List<string> { "USD", "EUR", "BRL", "GBP", "AUD" });

            // تبدیل به دیکشنری برای DTO
            var quotes = new Dictionary<string, decimal>
            {
                ["USD"] = priceUsd,
                ["EUR"] = priceUsd * rates["EUR"],
                ["BRL"] = priceUsd * rates["BRL"],
                ["GBP"] = priceUsd * rates["GBP"],
                ["AUD"] = priceUsd * rates["AUD"]
            };

            return new CryptoQuoteDto
            {
                Crypto = cryptoCode,
                Quotes = quotes
            };
        }
    }
}