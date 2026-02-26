using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CryptoQuote
    {
        public string CryptoCode { get; set; }
        public decimal PriceUsd { get; set; }
        public decimal PriceEur { get; set; }
        public decimal PriceBrl { get; set; }
        public decimal PriceGbp { get; set; }
        public decimal PriceAud { get; set; }
    }
}
