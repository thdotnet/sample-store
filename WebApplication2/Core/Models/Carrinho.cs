using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Core.Models
{
    public class Carrinho
    {
        public Carrinho()
        {
            Items = new List<CarrinhoItem>();
        }

        public decimal Total { get; set; }

        public int TotalItens
        {
            get
            {
                return Items.Count();
            }
        }

        public List<CarrinhoItem> Items { get; set; }

        public void Adicionar(Product produto)
        {
            if(Items.Any(x => x.Produto.Id == produto.Id))
            {
                var item = Items.FirstOrDefault(p => p.Produto.Id == produto.Id);
                item.Quantidade++;
            }
            else
            {
                Items.Add(new CarrinhoItem(produto, 1));
            }
        }
    }
}