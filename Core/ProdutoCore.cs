using Model;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class ProdutoCore
    {
        public List<Produto> ListarProdutos() => Base.Produtos.OrderBy(x => x.Valor).ToList();
        public Produto CadastrarProduto(Produto produto)
        {
            produto.Id = Base.ProdutoId += 1;
            Base.Produtos.Add(produto);
            return produto;
        }
    }
}
