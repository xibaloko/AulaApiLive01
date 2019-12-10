using Microsoft.AspNetCore.Mvc;
using Core;
using Model;

namespace AulaApiLive01.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new ProdutoCore().ListarProdutos());

        [HttpPost]
        public IActionResult Post(Produto produto) => Created("", new ProdutoCore().CadastrarProduto(produto));
    }
}