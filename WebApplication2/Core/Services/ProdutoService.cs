using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Core.Interfaces;
using WebApplication2.Infrastructure.Redis;
using WebApplication2.Infrastructure.Repository;
using WebApplication2.Models;

namespace WebApplication2.Core.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IRedisService<List<Product>> _redis;
        private readonly IProdutoRepository _repository;

        public ProdutoService(IRedisService<List<Product>> redis, IProdutoRepository repository)
        {
            _redis = redis;
            _repository = repository;
        }

        public Product ObterProduto(int id)
        {
            var item = _redis.Get<Product>($"p:{id}");

            if (item == null)
            {
                var produto = _repository.ObterProduto(id);

                _redis.Set($"p:{id}", JsonConvert.SerializeObject(produto));

                item = produto;
            }

            return item;
        }

        public List<Product> ObterProdutos(int contagem)
        {
            var items = _redis.Get<List<Product>>("produtos");

            if (items == null || items.Count == 0)
            {
                var produtos = _repository.ObterProdutos(contagem);
                _redis.Set("produtos", JsonConvert.SerializeObject(produtos));

                items = produtos;
            }

            return items;

            
        }
    }
}
