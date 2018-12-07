using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Core.Models
{
    public class CarrinhoItem
    {
        public CarrinhoItem(Product produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public Product Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
