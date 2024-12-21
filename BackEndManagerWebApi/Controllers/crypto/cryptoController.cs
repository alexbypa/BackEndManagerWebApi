using Asp.Versioning;
using BackEndManagerBusinessLogic.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace BackEndManagerWebApi.Controllers.crypto {
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class cryptoController : Controller {
        [HttpPost(Name = "encrpyt")]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> Encrypt(string clearText, string publicCertificatePath) {
            X509Helper x509Helper = new X509Helper(publicCertificatePath);
            string result = x509Helper.encrypt(clearText);

            return Ok(new {exception = x509Helper.exToThrow, encryptText = result});
        }
    }
}
