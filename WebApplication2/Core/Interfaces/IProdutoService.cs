using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Core.Interfaces
{
    public interface IProdutoService
    {
        List<Product> ObterProdutos(int quantidade);

        Product ObterProduto(int id);
    }
}
