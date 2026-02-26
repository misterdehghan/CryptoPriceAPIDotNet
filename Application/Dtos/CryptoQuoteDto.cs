using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class CryptoQuoteDto
    {
        public string Crypto { get; set; }
        public Dictionary<string, decimal> Quotes { get; set; }
    }
}
