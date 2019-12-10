using Microsoft.AspNetCore.Mvc;
using Model;
using Core;

namespace AulaApiLive01.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new UsuarioCore().ListarUsuarios());

        [HttpGet("{id}")]
        public IActionResult GetPorId(int id) => Ok(new UsuarioCore().GetUsuarioPorId(id));

        [HttpPost]
        public IActionResult Post(Usuario usuario) => Created("", new UsuarioCore().CadastrarUsuario(usuario));
    }
}