using WebApplication2.Core.Models;

namespace WebApplication2.Core.Services
{
    public interface ICarrinhoService
    {
        void Limpar(string usuario);

        Carrinho Obter(string usuario);

        void SalvarCarrinho(string usuario, Carrinho carrinho);
    }
}