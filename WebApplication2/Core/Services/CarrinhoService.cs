using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Core.Models;
using WebApplication2.Infrastructure.Redis;

namespace WebApplication2.Core.Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly IRedisService<Carrinho> _redis;

        public CarrinhoService(IRedisService<Carrinho> redis)
        {
            _redis = redis;
        }

        public Carrinho Obter(string usuario)
        {
            var carrinho = _redis.Get<Carrinho>($"carrinho:{usuario}");
            if (carrinho == null)
            {
                carrinho = new Carrinho();

                SalvarCarrinho(usuario, carrinho);
            }
            return carrinho;
        }

        public void Limpar(string usuario)
        {
            _redis.Delete($"carrinho:{usuario}");
        }

        public void SalvarCarrinho(string usuario, Carrinho carrinho)
        {            
            _redis.Set($"carrinho:{usuario}", JsonConvert.SerializeObject(carrinho));
        }
    }
}
