using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;


namespace Infrastructure
{
    public class CoinMarketCapClient: ICoinMarketCapClient
    {
        private readonly HttpClient _httpClient;
        private readonly CoinMarketCapOptions _options;

        public CoinMarketCapClient(
            HttpClient httpClient,
            IOptions<CoinMarketCapOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<decimal> GetPriceAsync(string cryptoCode)
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                $"{_options.BaseUrl}/v1/cryptocurrency/quotes/latest?symbol={cryptoCode}");

            request.Headers.Add("X-CMC_PRO_API_KEY", _options.ApiKey);

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                return 0;

            var content = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(content);

            return jsonDoc.RootElement
                .GetProperty("data")
                .GetProperty(cryptoCode.ToUpper())
                .GetProperty("quote")
                .GetProperty("USD")
                .GetProperty("price")
                .GetDecimal();
        }
    }
}
