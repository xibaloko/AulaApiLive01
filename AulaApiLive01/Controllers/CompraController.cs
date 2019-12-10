using Microsoft.AspNetCore.Mvc;
using Model;
using Core;

namespace AulaApiLive01.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new CompraCore().ListarCompras());

        [HttpPost]
        public IActionResult Post(Compra compra)
        {
            var resultado = new CompraCore().CadastrarCompra(compra);

            if (resultado == null)
                return BadRequest();

            return Created("", resultado);
        }
    }
}