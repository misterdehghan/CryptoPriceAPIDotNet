using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint
{
    [ApiController]
    [Route("api/[controller]")]
    public class CryptoController : ControllerBase
    {
        private readonly ICryptoService _cryptoService;

        public CryptoController(ICryptoService cryptoService)
        {
            _cryptoService = cryptoService;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            var result = await _cryptoService.GetQuoteAsync(code);

            if (result == null)
                return NotFound(new { error = "Invalid crypto code" });

            return Ok(result);
        }
    }
}