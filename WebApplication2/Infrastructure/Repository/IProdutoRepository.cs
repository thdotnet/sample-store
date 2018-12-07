using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Infrastructure.Repository
{
    public interface IProdutoRepository
    {
        Product ObterProduto(int id);
        List<Product> ObterProdutos(int count);
    }
}