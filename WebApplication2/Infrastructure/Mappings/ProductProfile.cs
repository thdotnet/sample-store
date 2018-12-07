using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProdutoListaViewModel>()
                .ForMember(m => m.Id, vm => vm.MapFrom(x => x.Id))
                .ForMember(m => m.Nome, vm => vm.MapFrom(x => x.Nome))
                .ForMember(m => m.Preco, vm => vm.MapFrom(x => x.Preco))
                .ForMember(m => m.Descricao, vm => vm.MapFrom(x => x.Descricao))
                .ForMember(m => m.ImagemPrincipal, vm => vm.MapFrom(x => x.ImagemPrincipalUrl));
        }
    }
}
