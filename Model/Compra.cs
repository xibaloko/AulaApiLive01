using System;

namespace Model
{
    public class Compra
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Carrinho CarrinhoCompras { get; set; }
        public DateTime DataCompra { get; set; } = DateTime.Now;
    }
}
