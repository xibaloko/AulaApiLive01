using System.Collections.Generic;
using Model;

namespace Core
{
    public static class Base
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public static List<Produto> Produtos { get; set; } = new List<Produto>();
        public static List<Compra> Compras { get; set; } = new List<Compra>();

        public static int UsuarioId { get; set; }
        public static int CompraId { get; set; }
        public static int ProdutoId { get; set; }
    }
}
