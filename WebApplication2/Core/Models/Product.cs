using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public Fabricante Fabricante { get; set; }

        public CaracteristicasProduto Caracteristicas { get; set; }

        public Categoria Categoria { get; set; }

        public Imagens[] Imagens { get; set; }

        public string ImagemPrincipalUrl { get; set; }

        public string[] Tags { get; set; }
    }
}
