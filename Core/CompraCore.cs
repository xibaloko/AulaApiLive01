using System.Collections.Generic;
using System.Linq;
using Model;

namespace Core
{
    public class CompraCore
    {
        public List<Compra> ListarCompras() => Base.Compras.OrderBy(x => x.DataCompra).ToList();

        public Compra CadastrarCompra(Compra compra)
        {
            compra.Id = Base.CompraId += 1;
            if (!Base.Usuarios.Any(x => x.Equals(compra.Usuario))) return null;
            if (!compra.CarrinhoCompras.ItensCompra.Any(x => x.Produto.Equals(Base.Produtos.FirstOrDefault()))) return null;
            Base.Compras.Add(compra);
            return compra;
        }
    }
}
