using Model;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class UsuarioCore
    {
        public Usuario CadastrarUsuario(Usuario usuario)
        {
            usuario.Id = Base.UsuarioId += 1;
            Base.Usuarios.Add(usuario);
            return usuario;
        }

        public List<Usuario> ListarUsuarios() => Base.Usuarios.OrderByDescending(x => x.Nome).ToList();

        public Usuario GetUsuarioPorId(int id) => Base.Usuarios.Find(x => x.Id == id);

    }
}
