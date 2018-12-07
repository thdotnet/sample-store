using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Product ObterProduto(int id)
        {
            return new Product
            {
                Id = 1,
                Descricao = "Celular Iphone XS MAX",
                Nome = "Iphone XS Max",
                Preco = 5500m,
                Tags = new[] { "iphone", "celular", "apple" },
                ImagemPrincipalUrl = "https://icdn2.digitaltrends.com/image/iphone-xs-max-review-1-1500x994.jpg",
                Imagens = new[] { new Imagens
                        {
                            Id = 1,
                            ImagemUrl = "https://icdn2.digitaltrends.com/image/iphone-xs-max-review-1-1500x994.jpg",
                            ProdutoId = 1
                        }
                    },
                Categoria = new Categoria
                {
                    Id = 1,
                    Nome = "Celular"
                },
                Caracteristicas = new CaracteristicasProduto
                {
                    Id = 1,
                    Cor = "Preta",
                    Altura = "15cm",
                    Largura = "7cm",
                    Peso = "600g"
                },
                Fabricante = new Fabricante
                {
                    Id = 1,
                    Nome = "Apple",
                    Logotipo = "http://doctorsacademyofeconomics.com/wp-content/uploads/2018/01/Apple.jpg"
                }
            };
        }

        public List<Product> ObterProdutos(int count)
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Descricao = "Celular Iphone XS MAX",
                    Nome = "Iphone XS Max",
                    Preco = 5500m,
                    Tags = new[] {"iphone", "celular", "apple"},
                    ImagemPrincipalUrl = "https://icdn2.digitaltrends.com/image/iphone-xs-max-review-1-1500x994.jpg",
                    Imagens = new[] { new Imagens
                        {
                            Id = 1,
                            ImagemUrl = "https://icdn2.digitaltrends.com/image/iphone-xs-max-review-1-1500x994.jpg",
                            ProdutoId = 1
                        }
                    },
                    Categoria = new Categoria{
                        Id = 1,
                        Nome = "Celular"
                    },
                    Caracteristicas = new CaracteristicasProduto
                    {
                        Id = 1,
                        Cor = "Preta",
                        Altura = "15cm",
                        Largura = "7cm",
                        Peso = "600g"
                    },
                    Fabricante = new Fabricante{
                        Id = 1,
                        Nome = "Apple",
                        Logotipo = "http://doctorsacademyofeconomics.com/wp-content/uploads/2018/01/Apple.jpg"
                    }
                }
            };
        }
    }
}
